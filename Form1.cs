using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Microsoft.FlightSimulator.SimConnect;
using Matric.Integration;
using System.ComponentModel;

public enum SimConnectDataTypes
{
    number,
    feet,
    radians,
    degrees,
    knots,
    inHg,
    millibars,
    mach
}
public enum MatricDataTypes
{
    output_number,
    output_decimal,
    output_string,
    output_heading,
    output_frequency,
    output_transponder,
    button
}

enum DEFINITIONS
{
    SimConnectData,
}

enum DATA_REQUESTS
{
    REQUEST_1,
};

enum EVENT_ID
{
    TEXT,
};


[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
public struct SimConnectData
{
    //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    //LOTS OF THINGS!
    public double d0;
    public double d1; public double d2; public double d3; public double d4; public double d5; public double d6; public double d7; public double d8; public double d9; public double d10;
    public double d11; public double d12; public double d13; public double d14; public double d15; public double d16; public double d17; public double d18; public double d19; public double d20;
    public double d21; public double d22; public double d23; public double d24; public double d25; public double d26; public double d27; public double d28; public double d29; public double d30;
    public double d31; public double d32; public double d33; public double d34; public double d35; public double d36; public double d37; public double d38; public double d39; public double d40;
    public double d41; public double d42; public double d43; public double d44; public double d45; public double d46; public double d47; public double d48; public double d49; public double d50;
    public double d51; public double d52; public double d53; public double d54; public double d55; public double d56; public double d57; public double d58; public double d59; public double d60;
    public double d61; public double d62; public double d63; public double d64; public double d65; public double d66; public double d67; public double d68; public double d69; public double d70;
    public double d71; public double d72; public double d73; public double d74; public double d75; public double d76; public double d77; public double d78; public double d79; public double d80;
    public double d81; public double d82; public double d83; public double d84; public double d85; public double d86; public double d87; public double d88; public double d89; public double d90;
    public double d91; public double d92; public double d93; public double d94; public double d95; public double d96; public double d97; public double d98; public double d99; public double d100;
    public double d101; public double d102; public double d103; public double d104; public double d105; public double d106; public double d107; public double d108; public double d109; public double d110;
    public double d111; public double d112; public double d113; public double d114; public double d115; public double d116; public double d117; public double d118; public double d119; public double d120;
    public double d121; public double d122; public double d123; public double d124; public double d125; public double d126; public double d127; public double d128; public double d129; public double d130;
    public double d131; public double d132; public double d133; public double d134; public double d135; public double d136; public double d137; public double d138; public double d139; public double d140;
    public double d141; public double d142; public double d143; public double d144; public double d145; public double d146; public double d147; public double d148; public double d149; public double d150;
    public double d151; public double d152; public double d153; public double d154; public double d155; public double d156; public double d157; public double d158; public double d159; public double d160;
    public double d161; public double d162; public double d163; public double d164; public double d165; public double d166; public double d167; public double d168; public double d169; public double d170;
    public double d171; public double d172; public double d173; public double d174; public double d175; public double d176; public double d177; public double d178; public double d179; public double d180;
    public double d181; public double d182; public double d183; public double d184; public double d185; public double d186; public double d187; public double d188; public double d189; public double d190;
    public double d191; public double d192; public double d193; public double d194; public double d195; public double d196; public double d197; public double d198; public double d199; public double d200;
}



namespace SimConnect2Matric2
{
    public partial class Form1 : Form
    {
        public DataTable myDataTable = new DataTable { TableName = "SimConnectDataTable" };

        // SimConnect object
        SimConnect simconnect = null;
        // User-defined win32 event
        const int WM_USER_SIMCONNECT = 0x0402;
        const int MAX_LOG_SIZE = 1024;

        readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "debug.log");
        readonly string dataTablePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataTable.xml");

        public Boolean SimConnectStatus = false;
        public Boolean RunSimConnect = false;

        public Boolean MatricStatus = false;
        public Boolean RunMatric = false;

        //const int MATRIC_PIN = 1234;
        const string MATRIC_APP_NAME = "SimConnect2Matric 2";
        const string MATRIC_DECK_ID = "";
        const int MATRIC_API_PORT = 50300;
        public static string CLIENT_ID;


        static Matric.Integration.Matric matric;

        //List<string> DataItemList = new List<string>();
        Dictionary<int, Dictionary<string, string>> DataDictionary = new Dictionary<int, Dictionary<string, string>>();

        public Form1()
        {
            InitializeComponent();
            ManageLogFile();
            InitializeDataGridView();
            InitializeDataTable();
            BindDataTableToDataGridView();
            //InitDataRequest();
            //InitMatric();

            updateLabels();

            this.FormClosing += Form1_FormClosing;

        }

        public void updateLabels()
        {
            if (MatricStatus)
            {
                labelMatricStatus.Text = "Online";
            }
            else
            {
                labelMatricStatus.Text = "Offline";
            }

            if (SimConnectStatus)
            {
                labelSimConnectStatus.Text = "Online";
            }
            else
            {
                labelSimConnectStatus.Text = "Offline";
            }

            if (RunMatric)
            {
                labelMatricEnabled.Text = "True";
            }
            else
            {
                labelMatricEnabled.Text = "False";
            }

            if (RunSimConnect)
            {
                labelSimConnectEnabled.Text = "True";
            }
            else
            {
                labelSimConnectEnabled.Text = "False";
            }
        }

        private void InitMatric()
        {
            updateLabels();
            WriteLog("Init Matric");
            try
            {
                matric = new Matric.Integration.Matric(MATRIC_APP_NAME, "", MATRIC_API_PORT);
            } catch (Exception ex)
            {
                WriteLog("Matric: " + ex.Message);
            }
            matric.PIN = "";
            matric.OnError += Matric_OnError;
            matric.OnConnectedClientsReceived += Matric_OnConnectedClientsReceived;
            matric.OnControlInteraction += Matric_OnControlInteraction;
            matric.OnVariablesChanged += Matric_OnVariablesChanged;

            MatricGetClients();
        }

        private void Matric_OnVariablesChanged(object sender, ServerVariablesChangedEventArgs data)
        {
            Console.WriteLine("Server variables changed");
            foreach (string varName in data.ChangedVariables)
            {
                Console.WriteLine($"{varName}: {data.Variables[varName].Value}");
            }
        }

        private void Matric_OnError(Exception ex)
        {
            Console.WriteLine(ex.Message);
            MatricStatus = false;
            updateLabels();
        }

        private void Matric_OnControlInteraction(object sender, object data)
        {
            Console.WriteLine("Control interaction:");
            Console.WriteLine(data.ToString());
        }

        private void Matric_OnConnectedClientsReceived(object source, List<ClientInfo> clients)
        {
            MatricUpdateClientsList(clients);
        }

        public void MatricUpdateClientsList(List<ClientInfo> connectedClients)
        {
            if (connectedClients.Count == 0)
            {
                MatricStatus = false;
                updateLabels();
                Console.WriteLine("No connected devices found, make sure your smartphone/tablet is connected\nPress any key to exit");
            }
            else
            {
                Console.WriteLine("Matric: Found devices:");
                MatricStatus = true;
                updateLabels();
                foreach (ClientInfo client in connectedClients)
                {
                    Console.WriteLine($@"{client.Id} {client.Name}");
                }
                CLIENT_ID = connectedClients[0].Id;
                Console.WriteLine("Starting test on first device");
                MatricTest();
            }
        }

        private void MatricTest()
        {
            ServerVariable vString = new ServerVariable()
            {
                Name = "demo_string",
                VariableType = ServerVariable.ServerVariableType.STRING,
                Value = "Initial string"
            };

            List<ServerVariable> variables = new List<ServerVariable>() {
                vString
            };
            matric.SetVariables(variables);
        }

        private void MatricGetClients()
        {
            WriteLog("Matric: Getting Clients");
            if (matric != null)
            {
                matric.GetConnectedClients();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteLog("User exit, disposing of connection");
            // Perform cleanup tasks or execute a function here
            // This code will run when the form is closing

            if (simconnect != null)
            {
                //simconnect.Dispose();
            }
        }

        private void ManageLogFile()
        {
            CheckDebugExists();
            LoadLogFile();
        }
        private async void LoadLogFile()
        {
            try{
                textLog.Text = File.ReadAllText(logFilePath);
                await Task.Delay(100);
                ScrollTextBoxToBottom(textLog);
            }
            catch (Exception ex)
            {
                WriteLog($"EXCEPTION whilst loading log: {ex.Message}");
                // Handle exceptions, e.g., display an error message
               // MessageBox.Show($"Error loading log file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void WriteLog(string newline)
        {
            //Console.WriteLine("Trying to write: "+newline);
            FileInfo fileInfo = new FileInfo(logFilePath);
            if (fileInfo.Exists)
            {
                //Console.WriteLine("fileInfo exists");
                // Get the size of the file in bytes
                long fileSizeInBytes = fileInfo.Length;

                // Convert bytes to kilobytes or megabytes for better readability
                double fileSizeInKB = fileSizeInBytes / 1024.0; // Bytes to Kilobytes

                string[] lines = File.ReadAllLines(logFilePath);

                if (fileSizeInKB > MAX_LOG_SIZE)
                {
                    // Skip the first line and get the remaining lines
                    lines = lines.Skip(50).ToArray();
                }
                lines = lines.Concat(new[] { DateTime.Now.ToString() + " - " + newline }).ToArray();
                try
                {
                    File.WriteAllLines(logFilePath, lines);

                }
                catch (IOException ex)
                {
                    // Handle the case where the file is in use
                    Console.WriteLine($"Error writing to the file: {ex.Message}");
                }
                LoadLogFile();
                
            }
        }

        private Boolean CheckDebugExists()
        {
            if (File.Exists(logFilePath) == false)
            {
                FileStream logFile = File.Create(logFilePath);
                logFile.Close();
                WriteLog("Log File Created");
            }
            if(File.Exists(logFilePath)) { return true; }else { return false; }
        }

        static void ScrollTextBoxToBottom(System.Windows.Forms.TextBox textBox)
        {
            textBox.SelectionStart = textBox.Text.Length;
            textBox.ScrollToCaret();
        }

        private void InitializeDataGridView()
        {
            WriteLog("Init DataGridView");
            // Create a DataGridViewComboBoxColumn for the enum field
            DataGridViewTextBoxColumn textDataItem = new DataGridViewTextBoxColumn
            {
                HeaderText = "Data Item",
                DataPropertyName = "DataItem",
                Width = 340
            };

            DataGridViewComboBoxColumn comboBoxDataType = new DataGridViewComboBoxColumn
            {
                HeaderText = "Data Type",
                DataPropertyName = "DataType",
                DataSource = Enum.GetValues(typeof(SimConnectDataTypes)),
                Width = 100
            };

            DataGridViewComboBoxColumn comboBoxMatricType = new DataGridViewComboBoxColumn
            {
                HeaderText = "Matric Type",
                DataPropertyName = "MatricType",
                DataSource = Enum.GetValues(typeof(MatricDataTypes)),
                Width = 170
            };

            // Add the DataGridViewComboBoxColumn to the DataGridView
            dataGridView1.Columns.Add(textDataItem);
            dataGridView1.Columns.Add(comboBoxDataType);
            dataGridView1.Columns.Add(comboBoxMatricType);

            // Subscribe to the DataError event
            dataGridView1.DataError += DataGridView1_DataError;

            dataGridView1.AutoGenerateColumns = false;
        }

        private void InitializeDataTable()
        {
            WriteLog("Init DataTable");
            myDataTable.Columns.Add("DataItem", typeof(string));
            myDataTable.Columns.Add("DataType", typeof(SimConnectDataTypes));
            myDataTable.Columns.Add("MatricType", typeof(MatricDataTypes));
            myDataTable.Columns.Add("Value", typeof(string));
        }

        private void BindDataTableToDataGridView()
        {
            WriteLog("Binding DataTable to DataGridView");
            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = myDataTable;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            WriteLog("User Triggered XML Save");
            SaveXML();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(baseDirectory);
            if (DataFileExist())
            {
                WriteLog("DataTable exists, will attempt to load XML.");
                LoadXML();
            }
        }

        private void SaveXML()
        {
            myDataTable.AcceptChanges();
            myDataTable.WriteXml(dataTablePath, XmlWriteMode.WriteSchema, true);
        }

        private void LoadXML()
        {

            try
            {
                // Load the XML file into a new DataTable
                DataTable newDataTable = new DataTable();
                newDataTable.ReadXml(dataTablePath);

                // Clear the existing rows in the current DataTable
                myDataTable.Rows.Clear();

                // Add the rows from the new DataTable to the current DataTable
                foreach (DataRow row in newDataTable.Rows)
                {
                    myDataTable.Rows.Add(row.ItemArray);
                }

                // Refresh the DataGridView to reflect the changes
                dataGridView1.Refresh();
                WriteLog("DataTable loaded");
            }
            catch (Exception ex)
            {
                WriteLog($"EXCEPTION loading DataTable: {ex.Message}");
                // Handle exceptions, e.g., display an error message
                MessageBox.Show($"Error loading XML file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean DataFileExist()
        {
            if(File.Exists(dataTablePath))
            { return true; }else { return false; }
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            LoadXML();
        }

        private void ButtonOpenSaveFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(dataTablePath);
        }

        private void ButtonSync_Click(object sender, EventArgs e)
        {
            //do stuff
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Handle the data error
            //MessageBox.Show($"Data error in row {e.RowIndex}, column {e.ColumnIndex}: {e.Exception.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Optionally, you can cancel the DataGridView's default behavior
            e.ThrowException = false;
        }

        private void BtnSimConnect_Click(object sender, EventArgs e)
        {
            simconnect = null;

            WriteLog("Enabling SimConnect Connection");
            RunSimConnect = true;
            InitDataRequest();
            this.Text = "Retry SimConnect";
            updateLabels();
        }

        private void BtnMatric_Click(object sender, EventArgs e)
        {
            WriteLog("Enabling Matric Connection");
            RunMatric = true;
            InitMatric();
            this.Text = "Retry Matric";
            updateLabels();
        }

        public string ObjToMatricType(object myObj)
        {
            MatricDataTypes[] enumValues = (MatricDataTypes[])Enum.GetValues(typeof(MatricDataTypes));
            if (int.TryParse(myObj.ToString(), out int intValue))
            {
                //Console.WriteLine($"Converted value: {intValue}");
                //Console.WriteLine($"Selected Enum Value: {selectedEnumValue}");
                MatricDataTypes selectedEnumValue = enumValues[intValue];
                return selectedEnumValue.ToString();
            }
            else
            {
                return "";
            }
        }
        public string ObjToDataType(object myObj)
        {
            SimConnectDataTypes[] enumValues = (SimConnectDataTypes[])Enum.GetValues(typeof(SimConnectDataTypes));
            if (int.TryParse(myObj.ToString(), out int intValue))
            {
                //Console.WriteLine($"Converted value: {intValue}");
                //Console.WriteLine($"Selected Enum Value: {selectedEnumValue}");
                SimConnectDataTypes selectedEnumValue = enumValues[intValue];
                return selectedEnumValue.ToString();
            }
            else
            {
                return "";
            }
        }

        private void InitDataRequest()
        {
            WriteLog("init DataRequest");

            try
            {
                simconnect = new SimConnect("Managed Data Request", this.Handle, WM_USER_SIMCONNECT, null, 0);
            }
            catch (COMException ex)
            {
                WriteLog("EXCEPTION SimConnect " + ex);
            }
            try
            {
                if (simconnect != null)
                {
                    SimConnectStatus = true;
                    updateLabels();
                    WriteLog("SimConnect DataRequest active");
                    // listen to connect and quit msgs
                    simconnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(Simconnect_OnRecvOpen);
                    simconnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(Simconnect_OnRecvQuit);

                    // listen to exceptions
                    simconnect.OnRecvException += new SimConnect.RecvExceptionEventHandler(Simconnect_OnRecvException);

                    DataDictionary.Clear();
                    int i = 0;

                    foreach (DataRow row in myDataTable.Rows)
                    {
                        //Console.WriteLine("Adding to def " + row["DataItem"].ToString() + " : " + ObjToDataType(row["DataType"]));
                        simconnect.AddToDataDefinition(DEFINITIONS.SimConnectData, row["DataItem"].ToString(), ObjToDataType(row["DataType"]), SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                        //DataItemList.Add(row["DataItem"].ToString());
                        DataDictionary[i] = new Dictionary<string, string> { { row["DataItem"].ToString(), "" } };
                        i++;
                    }
                    
                    // define a data structure
                    //simconnect.AddToDataDefinition(DEFINITIONS.SimConnectData, "PLANE LATITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                    // IMPORTANT: register it with the simconnect managed wrapper marshaller
                    // if you skip this step, you will only receive a uint in the .dwData field.
                    simconnect.RegisterDataDefineStruct<SimConnectData>(DEFINITIONS.SimConnectData);

                    // catch a simobject data request
                    simconnect.OnRecvSimobjectData += new SimConnect.RecvSimobjectDataEventHandler(Simconnect_OnRecvSimobjectData);

                    // Request FSX data every second
                    simconnect.RequestDataOnSimObject(DATA_REQUESTS.REQUEST_1
                         , DEFINITIONS.SimConnectData
                         , SimConnect.SIMCONNECT_OBJECT_ID_USER
                         , SIMCONNECT_PERIOD.VISUAL_FRAME   //SIM_FRAME   VISUAL_FRAME    SECOND
                         , SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT
                         , 0
                         , 0
                         , 0);

                }
                else
                {
                    WriteLog("SimConnect is not running.");
                }

            }
            catch (COMException ex)
            {
                WriteLog(ex.Message);
            }
        }

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WM_USER_SIMCONNECT)
            {
                if (simconnect != null)
                {
                    simconnect.ReceiveMessage();
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }

        void Simconnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            WriteLog("SimConnect connection established");
            SimConnectStatus = true;
            updateLabels();
        }

        // The case where the user closes the sim
        void Simconnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            WriteLog("SimConnect connection lost");
            SimConnectStatus = false;
            updateLabels();
        }

        void Simconnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
             WriteLog("SimConnect recieved an error: " + data.dwException);
            SimConnectStatus = false;
            updateLabels();
        }

        void Simconnect_OnRecvSimobjectData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
        {
            switch ((DATA_REQUESTS)data.dwRequestID)
            {
                case DATA_REQUESTS.REQUEST_1:
                    SimConnectData s1 = (SimConnectData)data.dwData[0];

                    if (RunSimConnect) { 
                    int i = 0;

                        foreach (DataRow row in myDataTable.Rows)
                        {

                            string fieldName = $"d{i}";
                            var fieldValue = typeof(SimConnectData).GetField(fieldName)?.GetValue(s1);
                            string formattedData = FormatData(fieldValue, ObjToMatricType(row["MatricType"]));

                            if (fieldValue != null)
                            {
                                if(formattedData != row["Value"].ToString())
                                { 
                                Console.WriteLine("value changed from "+ row["Value"].ToString()+" to "+ formattedData);
                                // Do something with the field value
                                //Console.WriteLine($"Value of {fieldName}: {fieldValue}");
                                row["Value"] = formattedData;
                                DataDictionary[i] = new Dictionary<string, string> { { row["DataItem"].ToString(), formattedData } };
                                }
                                else
                                {
                                    //Console.WriteLine($"{row["DataItem"].ToString()} has not changed.");
                                }
                            }
                            else
                            {
                                //Console.WriteLine($"Field with name {fieldName} not found");
                            }
                            i++;
                        }

                        //check if we're sending this to Matric
                        if(MatricStatus && RunMatric)
                        {

                            

                            List<ServerVariable> variables = new List<ServerVariable>() {
                            };

                            // Iterate through the outer dictionary
                            foreach (KeyValuePair<int, Dictionary<string, string>> outerKvp in DataDictionary)
                            {
                                //Console.WriteLine($"Key: {outerKvp.Key}");

                                // Iterate through the inner dictionary
                                foreach (KeyValuePair<string, string> innerKvp in outerKvp.Value)
                                {
                                    //Console.WriteLine($"  Inner Key: {innerKvp.Key}, Value: {innerKvp.Value}");
                                    ServerVariable vString = new ServerVariable()
                                    {
                                        Name = innerKvp.Key,
                                        VariableType = ServerVariable.ServerVariableType.STRING,
                                        Value = innerKvp.Value
                                    };
                                    variables.Add(vString);
                                }
                            }

                            matric.SetVariables(variables);

                        }

                        //DisplayDataDictionary();
                    }
                    break;

                default:
                    WriteLog("SimConnect Unknown request ID: " + data.dwRequestID);
                    break;
            }
        }

        private void DisplayDataDictionary()
        {
            foreach (var kvp in DataDictionary)
            {
                int outerKey = kvp.Key;
                Dictionary<string, string> innerDictionary = kvp.Value;

                //Console.WriteLine($"Outer Key: {outerKey}");

                foreach (var innerKvp in innerDictionary)
                {
                    string innerKey = innerKvp.Key;
                    string innerValue = innerKvp.Value;

                    Console.WriteLine($"{innerKey}: {innerValue}");
                }
            }
        }

        string FormatData(object input,string formatType)
        {
            //Console.WriteLine("Formatting: "+input.ToString()+" into the format "+formatType);
            string output="";
            double _input = Convert.ToDouble(input);
            switch (formatType)
            {

                case "output_decimal":
                    output = Convert.ToString(Math.Round(_input, 2));
                    break;

                case "output_number":
                    output = Convert.ToString(Math.Round(_input));
                    break;

                case "output_heading":
                    output = Convert.ToString(Math.Round(rad2deg(_input)));
                    break;

                case "output_transponder":
                    output = (_input < 10 ? "0" : "") + (_input < 100 ? "0" : "") + (_input < 1000 ? "0" : "") + Convert.ToString(_input);
                    break;

                case "output_frequency":
                    string inputstring = _input.ToString();
                    output = inputstring;
                    if (inputstring != "0")
                    {
                        output = inputstring.Substring(0, 3) + "." + inputstring.Substring(3, 3);
                    }
                    break;

                default:
                    //default
                    break;
            }
            return output;
        }


        static double deg2rad(double deg)
        {
            return deg * (Math.PI / 180);
        }
        static double rad2deg(double rad)
        {
            return rad * (180 / Math.PI);
        }
    }
}
