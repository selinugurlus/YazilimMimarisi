using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace YazilimMimarisi
{
    public partial class RaporForm : Form
    {
        DataTable xdt = new DataTable();
        
       
        public RaporForm()
        {
            InitializeComponent();
            // Create empty collection/datasource
            
        }
        static string constring = ("Data Source=DESKTOP-CFN2IQC;Initial Catalog=YazilimMimairsi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection baglan = new SqlConnection(constring);

        private void RezGetirbutton_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * From RezBilgileri Where musteri_mail='" + MailtextBox.Text + "'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            xdt = dt;
            baglan.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnamenuForm ana = new AnamenuForm();
            ana.Show();
            this.Hide();
        }

        private void MailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            
        }
       

        private void RaporAlbutton_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(xdt);
            ds.WriteXml(File.OpenWrite(@"C:\Users\user1\Desktop\Rapor Xml Olarak.xml"));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string output = JsonConvert.SerializeObject(xdt);
            System.IO.File.WriteAllText(@"C:\Users\user1\Desktop\Rapor Json Olarak.json", output);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string HtmlBody = ExportDatatableToHtml(xdt);
            System.IO.File.WriteAllText(@"C:\Users\user1\Desktop\Rapor Html Olarak.HTML", HtmlBody);
        }
        protected string ExportDatatableToHtml(DataTable dt)
        {
            StringBuilder strHTMLBuilder = new StringBuilder();
            strHTMLBuilder.Append("<html >");
            strHTMLBuilder.Append("<head>");
            strHTMLBuilder.Append("</head>");
            strHTMLBuilder.Append("<body>");
            strHTMLBuilder.Append("<table border='1px' cellpadding='10' cellspacing='3' bgcolor='lightyellow' style='font-family:Garamond; font-size:smaller'>");
            strHTMLBuilder.Append("<tr >");
            foreach (DataColumn myColumn in dt.Columns)
            {
                strHTMLBuilder.Append("<td >");
                strHTMLBuilder.Append(myColumn.ColumnName);
                strHTMLBuilder.Append("</td>");
            }
            strHTMLBuilder.Append("</tr>");
            foreach (DataRow myRow in xdt.Rows)
            {
                strHTMLBuilder.Append("<tr >");
                foreach (DataColumn myColumn in xdt.Columns)
                {
                    strHTMLBuilder.Append("<td >");
                    strHTMLBuilder.Append(myRow[myColumn.ColumnName].ToString());
                    strHTMLBuilder.Append("</td>");
                }
                strHTMLBuilder.Append("</tr>");
            }
            //Close tags.
            strHTMLBuilder.Append("</table>");
            strHTMLBuilder.Append("</body>");
            strHTMLBuilder.Append("</html>");
            string Htmltext = strHTMLBuilder.ToString();
            return Htmltext;
        }
    }
}
