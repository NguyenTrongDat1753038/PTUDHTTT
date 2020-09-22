using SPA_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerUI.UI.Room
{
    public partial class RoomInsert_Update : Form
    {
        public RoomInsert_Update()
        {
            InitializeComponent();
        }

        private void foreverComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
        }
        public int status;
        public PHONG trans;
        private void chuthich_TextChanged(object sender, EventArgs e)
        {
            if (loai.Text == "1")
                chuthich.Text = "Phòng thường";
            else if (loai.Text == "2")
                chuthich.Text = "Phòng trung - cao cấp";
            else if (loai.Text == "3")
                chuthich.Text = "Phòng đặc biệt";
        }
        private async void GetChiNhanhAsync()
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/CHINHANHs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;

            var data = await response.Content.ReadAsAsync<IList<CHINHANH>>();
            idcn.Items.Clear();
            foreach (var i in data)
            {
                idcn.Items.Add(i.ID_CHINHANH);
            }
        }
        private void RoomInsert_Update_Load(object sender, EventArgs e)
        {
            if (status == 0)
            {
                idcn.Enabled = true;
                insert_btn.Enabled = true;
                update_btn.Enabled = false;
                idp.ReadOnly = false;

            }
            else
            {
                idcn.Enabled = false;
                insert_btn.Enabled = false;
                idp.ReadOnly = true;
                update_btn.Enabled = true;
              
                
               
            }
        }
    }
}
