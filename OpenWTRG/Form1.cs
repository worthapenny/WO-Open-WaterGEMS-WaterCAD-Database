using System;
using System.Windows.Forms;
using Haestad.Domain;
using Haestad.Domain.ModelingObjects.Water;

/* 
Add References:
-  C:\Program Files (x86)\Bentley\WaterGEMS\x64\Haestad.Domain.dll
-  C:\Program Files (x86)\Bentley\WaterGEMS\x64\Haestad.Domain.ModelingObjects.dll
-  C:\Program Files (x86)\Bentley\WaterGEMS\x64\Haestad.Domain.ModelingObjects.Water.dll
-  C:\Program Files (x86)\Bentley\WaterGEMS\x64\Haestad.Support.dll

Platform Target:
-  x64

Update App.config:
-  Replace <startup> tag with below line
-  <startup useLegacyV2RuntimeActivationPolicy="true">
*/


namespace OpenWTRG
{
    public partial class FormOpenModel : Form
    {
        public FormOpenModel()
        {
            InitializeComponent();

            buttonOpen.Click += (o, e) => OpenModelDatabase(textBoxModelPath.Text);
            buttonClose.Click += (o, e) => CloseModelDatabase();
            FormClosing += (o, e) => CloseModelDatabase();
        }


        private IdahoDataSource DataSource { get; set; }

        /* 
         * This DomainDataSet provides a lot of options
         * when working with the database file, this
         * propperty will be used extensively later on.
         * 
         */
        private IDomainDataSet DomainDataSet { get; set; }

        private bool OpenModelDatabase(string sqliteFilePath)
        {
            bool successful = true;
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Close if open
                CloseModelDatabase();


                DataSource = new IdahoDataSource();
                DataSource.SetConnectionProperty(ConnectionProperty.FileName, sqliteFilePath);
                DataSource.SetConnectionProperty(ConnectionProperty.ConnectionType, ConnectionType.Sqlite);
                DataSource.SetConnectionProperty(ConnectionProperty.EnableSchemaUpdate, false);

                DataSource.Open();
                DomainDataSet = DataSource.DomainDataSetManager.DomainDataSet(1);

                Console.WriteLine($"Hydraulic model database got opened. Path: {sqliteFilePath}");

                // Now the model is open do what you need to do
                ModelOpened();

            }
            catch (System.Runtime.InteropServices.SEHException sehEx)
            {
                successful = false;
                string message =
                    "Exception occurred while opening up the model.\n May be you are trying to open a model from a directory where _ADMIN_ right is required to edit files?. \n\n";

                Console.WriteLine($"Exception: {message}");
                Console.WriteLine($"Destails: {sehEx.ToString()}");
            }
            catch (BadImageFormatException badImageEx)
            {
                successful = false;
                string message =
                    "Exception occurred while opening up the model. It appears 32/64 bit version conflict occurred. \n\n";

                Console.WriteLine($"Exception: {message}");
                Console.WriteLine($"Destails: {badImageEx.ToString()}");
            }
            catch (Exception ex)
            {
                successful = false;
                Console.WriteLine($"Destails: {ex.ToString()}");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            return successful;
        }


        private void CloseModelDatabase()
        {
            if (DataSource == null || !DataSource.IsOpen())
                return;

            DataSource.Close();
            DataSource.Dispose();
            DataSource = null;


            Console.WriteLine("Model database got closed.");

            // update the UI
            labelModelInfo.Text = "Model database got closed.";
        }

        private void ModelOpened()
        {
            // Let's show the pipe and juction could in the label
            int pipeCount = DomainDataSet.DomainElementManager((int)DomainElementType.IdahoPipeElementManager).ElementIDs().Count;
            int junctionCount = DomainDataSet.DomainElementManager((int)DomainElementType.IdahoJunctionElementManager).ElementIDs().Count;

            labelModelInfo.Text = $"Counts: Pipe = {pipeCount}, Junction = {junctionCount}";
        }

    }
}
