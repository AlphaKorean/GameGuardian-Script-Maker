namespace GameGuardian_Script_Maker
{
    public partial class MainForm : Form
    {
        string[] Ranges = { "ANONYMOUS", "ASHMEM", "BAD", "C_ALLOC", "C_BSS", "C_DATA", "C_HEAP", "CODE_APP", "CODE_SYS", "JAVA", "JAVA_HEAP", "OTHER", "PPSSPP", "STACK", "VIDEO" };
        string[] Types = { "AUTO", "BYTE", "DOUBLE", "DWORD", "FLOAT", "QWORD", "WORD", "XOR" };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbRanges.Items.AddRange(Ranges);
            cbRanges.SelectedIndex = 0;
            cbType.Items.AddRange(Types);
            cbType.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbHackName.Text) || string.IsNullOrEmpty(tbSearch.Text) || string.IsNullOrEmpty(tbCheck.Text) || string.IsNullOrEmpty(tbEdit.Text) || string.IsNullOrEmpty(tbToast.Text))
                return;

            String[] Script = { tbHackName.Text, cbRanges.Text, tbSearch.Text, cbType.Text, tbCheck.Text, tbEdit.Text, tbToast.Text };
            ListViewItem Hack = new ListViewItem(Script);
            lVHackType.Items.Add(Hack);

            tbHackName.Clear();
            cbRanges.SelectedIndex = 0;
            tbSearch.Clear();
            cbType.SelectedIndex = 0;
            tbCheck.Clear();
            tbEdit.Clear();
            tbToast.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lVHackType.Items.Count > 0)
                lVHackType.Items.Remove(lVHackType.SelectedItems[0]);
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\jangw\Downloads\Output.lua";

            using (File.Create(path));

            LuaWrite(path);
        }

        private void LuaWrite(string path)
        {
            if (lVHackType.Items.Count <= 0 || lVHackType.Items.Count >= 5)
                return;

            StreamWriter writer;
            writer = File.AppendText(path);
            writer.WriteLine("function Home()");
            writer.WriteLine("menu = gg.choice({");

            writer.WriteLine("'" + lVHackType.Items[0].SubItems[0].Text + "',");
            writer.WriteLine("'" + lVHackType.Items[1].SubItems[0].Text + "',");
            writer.WriteLine("'" + lVHackType.Items[2].SubItems[0].Text + "',");
            writer.WriteLine("'스크립트 종료'})\n");

            writer.WriteLine("if menu == 1 then First() end\nif menu == 2 then Second() end\nif menu == 3 then Third() end\nif menu == 4 then Exit() end\n");
            writer.WriteLine("Main = - 1 end\n");

            writer.WriteLine("function First()");
            writer.WriteLine("gg.setRanges(gg.REGION_" + lVHackType.Items[0].SubItems[1].Text + ")");
            writer.WriteLine("gg.clearResults()");
            writer.WriteLine("gg.searchNumber('" + lVHackType.Items[0].SubItems[2].Text + "', gg.TYPE_" + lVHackType.Items[0].SubItems[3].Text + ")");
            writer.WriteLine("gg.getResults(" + lVHackType.Items[0].SubItems[4].Text + ")");
            writer.WriteLine("gg.editAll('" + lVHackType.Items[0].SubItems[5].Text + "', gg.TYPE_" + lVHackType.Items[0].SubItems[3].Text + ")");
            writer.WriteLine("gg.clearResults()");
            writer.WriteLine("gg.toast('" + lVHackType.Items[0].SubItems[6].Text + "')");
            writer.WriteLine("end\n");

            writer.WriteLine("function Second()");
            writer.WriteLine("gg.setRanges(gg.REGION_" + lVHackType.Items[1].SubItems[1].Text + ")");
            writer.WriteLine("gg.clearResults()");
            writer.WriteLine("gg.searchNumber('" + lVHackType.Items[1].SubItems[2].Text + "', gg.TYPE_" + lVHackType.Items[1].SubItems[3].Text + ")");
            writer.WriteLine("gg.getResults(" + lVHackType.Items[1].SubItems[4].Text + ")");
            writer.WriteLine("gg.editAll('" + lVHackType.Items[1].SubItems[5].Text + "', gg.TYPE_" + lVHackType.Items[1].SubItems[3].Text + ")");
            writer.WriteLine("gg.clearResults()");
            writer.WriteLine("gg.toast('" + lVHackType.Items[1].SubItems[6].Text + "')");
            writer.WriteLine("end\n");

            writer.WriteLine("function Third()");
            writer.WriteLine("gg.setRanges(gg.REGION_" + lVHackType.Items[2].SubItems[1].Text + ")");
            writer.WriteLine("gg.clearResults()");
            writer.WriteLine("gg.searchNumber('" + lVHackType.Items[2].SubItems[2].Text + "', gg.TYPE_" + lVHackType.Items[2].SubItems[3].Text + ")");
            writer.WriteLine("gg.getResults(" + lVHackType.Items[2].SubItems[4].Text + ")");
            writer.WriteLine("gg.editAll('" + lVHackType.Items[2].SubItems[5].Text + "', gg.TYPE_" + lVHackType.Items[2].SubItems[3].Text + ")");
            writer.WriteLine("gg.clearResults()");
            writer.WriteLine("gg.toast('" + lVHackType.Items[2].SubItems[6].Text + "')");
            writer.WriteLine("end\n");

            writer.WriteLine("function Exit()\nprint('스크립트를 이용해주셔서 감사합니다')\nos.exit()\nend\n");
            writer.WriteLine("while(true)\ndo\n  if gg.isVisible(true) then\n    Main = 1\n    gg.setVisible(false) \n  end \n  if main==1 then \n Home() \n end\nend");

            writer.Close();

            MessageBox.Show("추출이 완료 되었습니다", "Script Tool");
        }
    }
}