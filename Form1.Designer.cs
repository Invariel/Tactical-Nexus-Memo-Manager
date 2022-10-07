namespace Tactical_Nexus_Note_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.layout_tbl_Main = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Directory = new System.Windows.Forms.Label();
            this.lbl_LevelName = new System.Windows.Forms.Label();
            this.layout_flow_Directory = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_Directory = new System.Windows.Forms.TextBox();
            this.btn_Directory = new System.Windows.Forms.Button();
            this.layout_flow_LevelName = new System.Windows.Forms.FlowLayoutPanel();
            this.cmb_LevelNames = new System.Windows.Forms.ComboBox();
            this.btn_LevelNameRefresh = new System.Windows.Forms.Button();
            this.dg_MemoFiles = new System.Windows.Forms.DataGridView();
            this.bs_Filenames = new System.Windows.Forms.BindingSource(this.components);
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filehashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_tbl_Main.SuspendLayout();
            this.layout_flow_Directory.SuspendLayout();
            this.layout_flow_LevelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_MemoFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Filenames)).BeginInit();
            this.SuspendLayout();
            // 
            // layout_tbl_Main
            // 
            this.layout_tbl_Main.ColumnCount = 2;
            this.layout_tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84536F));
            this.layout_tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.15464F));
            this.layout_tbl_Main.Controls.Add(this.lbl_Directory, 0, 0);
            this.layout_tbl_Main.Controls.Add(this.lbl_LevelName, 0, 1);
            this.layout_tbl_Main.Controls.Add(this.layout_flow_Directory, 1, 0);
            this.layout_tbl_Main.Controls.Add(this.layout_flow_LevelName, 1, 1);
            this.layout_tbl_Main.Controls.Add(this.dg_MemoFiles, 1, 2);
            this.layout_tbl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_tbl_Main.Location = new System.Drawing.Point(0, 0);
            this.layout_tbl_Main.Name = "layout_tbl_Main";
            this.layout_tbl_Main.RowCount = 3;
            this.layout_tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layout_tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layout_tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_tbl_Main.Size = new System.Drawing.Size(800, 449);
            this.layout_tbl_Main.TabIndex = 0;
            // 
            // lbl_Directory
            // 
            this.lbl_Directory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Directory.AutoSize = true;
            this.lbl_Directory.Location = new System.Drawing.Point(73, 10);
            this.lbl_Directory.Name = "lbl_Directory";
            this.lbl_Directory.Size = new System.Drawing.Size(82, 15);
            this.lbl_Directory.TabIndex = 0;
            this.lbl_Directory.Text = "Data Directory";
            // 
            // lbl_LevelName
            // 
            this.lbl_LevelName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_LevelName.AutoSize = true;
            this.lbl_LevelName.Location = new System.Drawing.Point(86, 45);
            this.lbl_LevelName.Name = "lbl_LevelName";
            this.lbl_LevelName.Size = new System.Drawing.Size(69, 15);
            this.lbl_LevelName.TabIndex = 1;
            this.lbl_LevelName.Text = "Level Name";
            // 
            // layout_flow_Directory
            // 
            this.layout_flow_Directory.Controls.Add(this.txt_Directory);
            this.layout_flow_Directory.Controls.Add(this.btn_Directory);
            this.layout_flow_Directory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_flow_Directory.Location = new System.Drawing.Point(161, 3);
            this.layout_flow_Directory.Name = "layout_flow_Directory";
            this.layout_flow_Directory.Size = new System.Drawing.Size(636, 29);
            this.layout_flow_Directory.TabIndex = 2;
            // 
            // txt_Directory
            // 
            this.txt_Directory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Directory.Location = new System.Drawing.Point(3, 3);
            this.txt_Directory.Name = "txt_Directory";
            this.txt_Directory.Size = new System.Drawing.Size(593, 23);
            this.txt_Directory.TabIndex = 0;
            // 
            // btn_Directory
            // 
            this.btn_Directory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Directory.Image = ((System.Drawing.Image)(resources.GetObject("btn_Directory.Image")));
            this.btn_Directory.Location = new System.Drawing.Point(602, 3);
            this.btn_Directory.Name = "btn_Directory";
            this.btn_Directory.Size = new System.Drawing.Size(31, 23);
            this.btn_Directory.TabIndex = 1;
            this.btn_Directory.UseVisualStyleBackColor = true;
            // 
            // layout_flow_LevelName
            // 
            this.layout_flow_LevelName.Controls.Add(this.cmb_LevelNames);
            this.layout_flow_LevelName.Controls.Add(this.btn_LevelNameRefresh);
            this.layout_flow_LevelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_flow_LevelName.Location = new System.Drawing.Point(161, 38);
            this.layout_flow_LevelName.Name = "layout_flow_LevelName";
            this.layout_flow_LevelName.Size = new System.Drawing.Size(636, 29);
            this.layout_flow_LevelName.TabIndex = 3;
            // 
            // cmb_LevelNames
            // 
            this.cmb_LevelNames.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_LevelNames.FormattingEnabled = true;
            this.cmb_LevelNames.Location = new System.Drawing.Point(3, 3);
            this.cmb_LevelNames.Name = "cmb_LevelNames";
            this.cmb_LevelNames.Size = new System.Drawing.Size(593, 23);
            this.cmb_LevelNames.TabIndex = 0;
            // 
            // btn_LevelNameRefresh
            // 
            this.btn_LevelNameRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_LevelNameRefresh.Image")));
            this.btn_LevelNameRefresh.Location = new System.Drawing.Point(602, 3);
            this.btn_LevelNameRefresh.Name = "btn_LevelNameRefresh";
            this.btn_LevelNameRefresh.Size = new System.Drawing.Size(31, 23);
            this.btn_LevelNameRefresh.TabIndex = 1;
            this.btn_LevelNameRefresh.UseVisualStyleBackColor = true;
            // 
            // dg_MemoFiles
            // 
            this.dg_MemoFiles.AutoGenerateColumns = false;
            this.dg_MemoFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_MemoFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filenameDataGridViewTextBoxColumn,
            this.filehashDataGridViewTextBoxColumn});
            this.dg_MemoFiles.DataSource = this.bs_Filenames;
            this.dg_MemoFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_MemoFiles.Location = new System.Drawing.Point(161, 73);
            this.dg_MemoFiles.Name = "dg_MemoFiles";
            this.dg_MemoFiles.RowTemplate.Height = 25;
            this.dg_MemoFiles.Size = new System.Drawing.Size(636, 373);
            this.dg_MemoFiles.TabIndex = 4;
            // 
            // bs_Filenames
            // 
            this.bs_Filenames.DataSource = typeof(Tactical_Nexus_Note_Manager.MemoFile);
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "Filename";
            this.filenameDataGridViewTextBoxColumn.FillWeight = 66F;
            this.filenameDataGridViewTextBoxColumn.HeaderText = "Filename";
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            // 
            // filehashDataGridViewTextBoxColumn
            // 
            this.filehashDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filehashDataGridViewTextBoxColumn.DataPropertyName = "Filehash";
            this.filehashDataGridViewTextBoxColumn.FillWeight = 33F;
            this.filehashDataGridViewTextBoxColumn.HeaderText = "Filehash";
            this.filehashDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.filehashDataGridViewTextBoxColumn.Name = "filehashDataGridViewTextBoxColumn";
            this.filehashDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.layout_tbl_Main);
            this.Name = "Form1";
            this.Text = "Tactical Nexus Memo Manager";
            this.layout_tbl_Main.ResumeLayout(false);
            this.layout_tbl_Main.PerformLayout();
            this.layout_flow_Directory.ResumeLayout(false);
            this.layout_flow_Directory.PerformLayout();
            this.layout_flow_LevelName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_MemoFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Filenames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel layout_tbl_Main;
        private Label lbl_Directory;
        private Label lbl_LevelName;
        private FlowLayoutPanel layout_flow_Directory;
        private TextBox txt_Directory;
        private Button btn_Directory;
        private FlowLayoutPanel layout_flow_LevelName;
        private ComboBox cmb_LevelNames;
        private Button btn_LevelNameRefresh;
        private DataGridView dg_MemoFiles;
        private BindingSource bs_Filenames;
        private DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filehashDataGridViewTextBoxColumn;
    }
}