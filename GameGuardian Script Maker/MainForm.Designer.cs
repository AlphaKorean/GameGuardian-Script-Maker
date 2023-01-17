namespace GameGuardian_Script_Maker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.lbMaker = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbRanges = new System.Windows.Forms.ComboBox();
            this.lbRanges = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbCheck = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbToast = new System.Windows.Forms.Label();
            this.lbEdit = new System.Windows.Forms.Label();
            this.lbHackName = new System.Windows.Forms.Label();
            this.tbCheck = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbToast = new System.Windows.Forms.TextBox();
            this.tbEdit = new System.Windows.Forms.TextBox();
            this.tbHackName = new System.Windows.Forms.TextBox();
            this.lVHackType = new System.Windows.Forms.ListView();
            this.cHName = new System.Windows.Forms.ColumnHeader();
            this.cHRanges = new System.Windows.Forms.ColumnHeader();
            this.cHSearch = new System.Windows.Forms.ColumnHeader();
            this.cHType = new System.Windows.Forms.ColumnHeader();
            this.cHCheck = new System.Windows.Forms.ColumnHeader();
            this.cHEdit = new System.Windows.Forms.ColumnHeader();
            this.cHToast = new System.Windows.Forms.ColumnHeader();
            this.gbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.lbMaker);
            this.gbInput.Controls.Add(this.btnRemove);
            this.gbInput.Controls.Add(this.btnOutput);
            this.gbInput.Controls.Add(this.btnAdd);
            this.gbInput.Controls.Add(this.cbType);
            this.gbInput.Controls.Add(this.cbRanges);
            this.gbInput.Controls.Add(this.lbRanges);
            this.gbInput.Controls.Add(this.lbType);
            this.gbInput.Controls.Add(this.lbCheck);
            this.gbInput.Controls.Add(this.lbSearch);
            this.gbInput.Controls.Add(this.lbToast);
            this.gbInput.Controls.Add(this.lbEdit);
            this.gbInput.Controls.Add(this.lbHackName);
            this.gbInput.Controls.Add(this.tbCheck);
            this.gbInput.Controls.Add(this.tbSearch);
            this.gbInput.Controls.Add(this.tbToast);
            this.gbInput.Controls.Add(this.tbEdit);
            this.gbInput.Controls.Add(this.tbHackName);
            this.gbInput.Font = new System.Drawing.Font("메이플스토리", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbInput.ForeColor = System.Drawing.Color.White;
            this.gbInput.Location = new System.Drawing.Point(12, 12);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(537, 190);
            this.gbInput.TabIndex = 0;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "기능 셋팅";
            // 
            // lbMaker
            // 
            this.lbMaker.AutoSize = true;
            this.lbMaker.ForeColor = System.Drawing.Color.White;
            this.lbMaker.Location = new System.Drawing.Point(403, 156);
            this.lbMaker.Name = "lbMaker";
            this.lbMaker.Size = new System.Drawing.Size(128, 21);
            this.lbMaker.TabIndex = 4;
            this.lbMaker.Text = "Made By 알파";
            // 
            // btnRemove
            // 
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(381, 122);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 28);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "선택한 항목 제거";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Font = new System.Drawing.Font("메이플스토리", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOutput.ForeColor = System.Drawing.Color.Black;
            this.btnOutput.Location = new System.Drawing.Point(284, 152);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(91, 28);
            this.btnOutput.TabIndex = 3;
            this.btnOutput.Text = "추출";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(284, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(153, 122);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(125, 26);
            this.cbType.TabIndex = 2;
            // 
            // cbRanges
            // 
            this.cbRanges.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRanges.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRanges.FormattingEnabled = true;
            this.cbRanges.Location = new System.Drawing.Point(153, 60);
            this.cbRanges.Name = "cbRanges";
            this.cbRanges.Size = new System.Drawing.Size(125, 26);
            this.cbRanges.TabIndex = 2;
            // 
            // lbRanges
            // 
            this.lbRanges.AutoSize = true;
            this.lbRanges.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbRanges.Location = new System.Drawing.Point(16, 62);
            this.lbRanges.Name = "lbRanges";
            this.lbRanges.Size = new System.Drawing.Size(131, 21);
            this.lbRanges.TabIndex = 1;
            this.lbRanges.Text = "검색 범위 설정 :";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbType.Location = new System.Drawing.Point(16, 124);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(133, 21);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "검색 할 값 유형 :";
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbCheck.Location = new System.Drawing.Point(16, 155);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(112, 21);
            this.lbCheck.TabIndex = 1;
            this.lbCheck.Text = "값 선택 갯수 :";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbSearch.Location = new System.Drawing.Point(16, 93);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(96, 21);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "검색 할 값 :";
            // 
            // lbToast
            // 
            this.lbToast.AutoSize = true;
            this.lbToast.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbToast.Location = new System.Drawing.Point(284, 61);
            this.lbToast.Name = "lbToast";
            this.lbToast.Size = new System.Drawing.Size(104, 21);
            this.lbToast.TabIndex = 1;
            this.lbToast.Text = "원하는 문구 :";
            // 
            // lbEdit
            // 
            this.lbEdit.AutoSize = true;
            this.lbEdit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbEdit.Location = new System.Drawing.Point(284, 31);
            this.lbEdit.Name = "lbEdit";
            this.lbEdit.Size = new System.Drawing.Size(91, 21);
            this.lbEdit.TabIndex = 1;
            this.lbEdit.Text = "변경할 값 :";
            // 
            // lbHackName
            // 
            this.lbHackName.AutoSize = true;
            this.lbHackName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbHackName.Location = new System.Drawing.Point(16, 31);
            this.lbHackName.Name = "lbHackName";
            this.lbHackName.Size = new System.Drawing.Size(75, 21);
            this.lbHackName.TabIndex = 1;
            this.lbHackName.Text = "핵 이름 :";
            // 
            // tbCheck
            // 
            this.tbCheck.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCheck.Location = new System.Drawing.Point(153, 154);
            this.tbCheck.Name = "tbCheck";
            this.tbCheck.Size = new System.Drawing.Size(125, 25);
            this.tbCheck.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearch.Location = new System.Drawing.Point(153, 92);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(125, 25);
            this.tbSearch.TabIndex = 0;
            // 
            // tbToast
            // 
            this.tbToast.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbToast.Location = new System.Drawing.Point(406, 61);
            this.tbToast.Name = "tbToast";
            this.tbToast.Size = new System.Drawing.Size(125, 25);
            this.tbToast.TabIndex = 0;
            // 
            // tbEdit
            // 
            this.tbEdit.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEdit.Location = new System.Drawing.Point(406, 31);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(125, 25);
            this.tbEdit.TabIndex = 0;
            // 
            // tbHackName
            // 
            this.tbHackName.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHackName.Location = new System.Drawing.Point(153, 30);
            this.tbHackName.Name = "tbHackName";
            this.tbHackName.Size = new System.Drawing.Size(125, 25);
            this.tbHackName.TabIndex = 0;
            // 
            // lVHackType
            // 
            this.lVHackType.BackColor = System.Drawing.Color.White;
            this.lVHackType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHName,
            this.cHRanges,
            this.cHSearch,
            this.cHType,
            this.cHCheck,
            this.cHEdit,
            this.cHToast});
            this.lVHackType.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lVHackType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lVHackType.FullRowSelect = true;
            this.lVHackType.GridLines = true;
            this.lVHackType.Location = new System.Drawing.Point(12, 208);
            this.lVHackType.Name = "lVHackType";
            this.lVHackType.Size = new System.Drawing.Size(537, 194);
            this.lVHackType.TabIndex = 1;
            this.lVHackType.UseCompatibleStateImageBehavior = false;
            this.lVHackType.View = System.Windows.Forms.View.Details;
            // 
            // cHName
            // 
            this.cHName.Text = "핵 이름";
            this.cHName.Width = 90;
            // 
            // cHRanges
            // 
            this.cHRanges.Text = "검색 범위";
            this.cHRanges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHRanges.Width = 100;
            // 
            // cHSearch
            // 
            this.cHSearch.Text = "값";
            this.cHSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHSearch.Width = 50;
            // 
            // cHType
            // 
            this.cHType.Text = "유형";
            this.cHType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHType.Width = 80;
            // 
            // cHCheck
            // 
            this.cHCheck.Text = "갯수";
            this.cHCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHCheck.Width = 50;
            // 
            // cHEdit
            // 
            this.cHEdit.Text = "변경 값";
            // 
            // cHToast
            // 
            this.cHToast.Text = "문구";
            this.cHToast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHToast.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(561, 414);
            this.Controls.Add(this.lVHackType);
            this.Controls.Add(this.gbInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(577, 453);
            this.MinimumSize = new System.Drawing.Size(577, 453);
            this.Name = "MainForm";
            this.Text = "GameGuardian Script Maker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbInput;
        private Label lbMaker;
        private Button btnRemove;
        private Button btnAdd;
        private ComboBox cbType;
        private ComboBox cbRanges;
        private Label lbRanges;
        private Label lbType;
        private Label lbCheck;
        private Label lbSearch;
        private Label lbToast;
        private Label lbEdit;
        private Label lbHackName;
        private TextBox tbCheck;
        private TextBox tbSearch;
        private TextBox tbToast;
        private TextBox tbEdit;
        private TextBox tbHackName;
        private ListView lVHackType;
        private Button btnOutput;
        private ColumnHeader cHName;
        private ColumnHeader cHRanges;
        private ColumnHeader cHSearch;
        private ColumnHeader cHType;
        private ColumnHeader cHCheck;
        private ColumnHeader cHEdit;
        private ColumnHeader cHToast;
    }
}