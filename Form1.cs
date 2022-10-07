using System.Security.Cryptography;

namespace Tactical_Nexus_Note_Manager
{
    public partial class Form1 : Form
    {
        public Dictionary<string, List<MemoFile>> MemoFiles = new Dictionary<string, List<MemoFile>>();
        public IList<string> LevelNames { get { return MemoFiles.Keys.ToList(); } }

        public Form1()
        {
            InitializeComponent();

            btn_Directory.Click += ChooseDirectory;
            btn_LevelNameRefresh.Click += UpdateDirectory;

            txt_Directory.TextChanged += UpdateDirectory;

            cmb_LevelNames.SelectedValueChanged += UpdateFileList;
            cmb_LevelNames.SelectionChangeCommitted += UpdateFileList;

            dg_MemoFiles.CellDoubleClick += ChangeMemoFile;
        }

        public void ChooseDirectory (object? sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Where are your Memo Files?";
            fbd.UseDescriptionForTitle = true;
            
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_Directory.Text = fbd.SelectedPath;
            }
        }

        public void UpdateFileList (object? sender, EventArgs e)
        {
            dg_MemoFiles.DataSource = MemoFiles[cmb_LevelNames.Text];
            dg_MemoFiles.Update();
            
        }

        public void ChangeMemoFile (object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
                return;

            MemoFile sourceFile = MemoFiles[cmb_LevelNames.Text][e.RowIndex];
            string parentFileName = $"memo-{cmb_LevelNames.Text}.dat";

            string originalLevel = cmb_LevelNames.Text;

            try
            {
                string sourceFileName = Path.Combine(sourceFile.FullFilename);
                string destFileName = Path.Combine(sourceFile.FileDirectory.FullName, parentFileName);

                File.Copy(sourceFileName, destFileName, true);

                UpdateDirectory(sender, e);
                cmb_LevelNames.Text = originalLevel;
            }
            catch (IOException ex)
            {
                MessageBox.Show("The level's memo file is in use.");
            }
        }

        public void UpdateDirectory (object? sender, EventArgs e)
        {
            string levelName = "";
            if (!string.IsNullOrEmpty(cmb_LevelNames.Text))
            {
                levelName = cmb_LevelNames.Text;
            }

            GetDirectoryContents();

            cmb_LevelNames.DataSource = LevelNames;
            cmb_LevelNames.Update();

            if (!string.IsNullOrEmpty(levelName))
            {
                cmb_LevelNames.Text = levelName;
            }
        }

        public void GetDirectoryContents ()
        {
            // Each note in the file is delineated by the bytes aa 55
            MemoFiles.Clear();
            List<MemoFile> memoFiles = new List<MemoFile>();

            if (Directory.Exists(txt_Directory.Text))
            {
                DirectoryInfo directory = new DirectoryInfo(txt_Directory.Text);

                foreach (var memoFile in directory.GetFiles("memo-*.dat"))
                {
                    MemoFile m = new MemoFile(directory, memoFile.Name);
                    string levelName = memoFile.Name.Substring(5);
                    levelName = levelName.Substring(0, levelName.Length - 4);

                    if (levelName.Contains("_"))
                    {
                        levelName = levelName.Substring(0, levelName.IndexOf("_"));
                    }

                    if (!MemoFiles.ContainsKey(levelName))
                    {
                        MemoFiles.Add(levelName, new List<MemoFile>());
                    }

                    MemoFiles[levelName].Add(m);
                }
            }
        }
    }

    public class MemoFile
    {
        string _fileHash = null;

        public DirectoryInfo FileDirectory { get; set; }

        public string FullFilename { get; set; }

        public string Filename { get; set; }

        public string Filehash
        {
            get
            {
                if (_fileHash is null)
                {
                    _fileHash = CalculateHash(FullFilename);
                }

                return _fileHash;
            }
        }

        public MemoFile (DirectoryInfo fileDirectory, string filename)
        {
            FileDirectory = fileDirectory;
            FullFilename = Path.Combine(fileDirectory.FullName, filename);
            Filename = filename;
            string _ = Filehash;
        }

        public static string CalculateHash(string filename)
        {
            string hash = "";

            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    hash = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }

            return hash;
        }
    }
}