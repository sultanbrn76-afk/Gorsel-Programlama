using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draganddrop
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        private void txtGiris_Click(object sender, EventArgs e)
        {
           
        }

        private void txtGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEkle.PerformClick();
            }
        }

        private void btnEkle_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var eklenecekdeger = txtGiris.Text.Trim();
            if (!string.IsNullOrEmpty(eklenecekdeger))
            {
                lstİllerA.Items.Add(eklenecekdeger);
                txtGiris.Text = string.Empty;
                txtGiris.Focus();

            }
        }

        private void btnsecilenigoster_Click(object sender, EventArgs e)
        {
            var secilendegerler = lstİllerA.SelectedItems;
            string mesaj = string.Empty;
            if(secilendegerler.Count>0)
            {
                foreach(var item in secilendegerler)
                {
                    mesaj = mesaj + $"{item}\n";
                }
                MessageBox.Show(mesaj, "BİLGİ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("lütfen il seçiniz","bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            var secilenindexler = lstİllerA.SelectedIndices;
            if(secilenindexler.Count>0 )
            {
                for(int i=secilenindexler.Count-1; i>=0; i--)
                {
                    lstİllerA.Items.RemoveAt(secilenindexler[i]);
                }
            }
        }

        private void btnAktarAb_Click(object sender, EventArgs e)
        {
             var secilendegerler = lstİllerA.SelectedItems;
            var secilenindexler = lstİllerA.SelectedIndices;

            if(secilendegerler.Count > 0)
            {
                foreach (var item in secilendegerler)
                {
                    lstİllerB.Items.Add(item); 
                }
                for(int i = secilenindexler.Count - 1; i >= 0; i--)
                {
                    lstİllerA.Items.RemoveAt(secilenindexler[i]);
                }

            }
            

        }

        private void btnaktarba_Click(object sender, EventArgs e)
        {

             var secilendegerler = lstİllerB.SelectedItems;
            var secilenindexler = lstİllerB.SelectedIndices;

            if (secilendegerler.Count > 0)
            {
                foreach (var Item in secilendegerler)
                {
                    lstİllerA.Items.Add(Item);
                }
                for (int i = secilenindexler.Count - 1; i >= 0; i--)
                {
                    lstİllerB.Items.RemoveAt(secilenindexler[i]);
                }

            }
        }

        private void lstİllerA_MouseDown(object sender, MouseEventArgs e)
        {

            var secilendegerler = lstİllerA.SelectedItems;
            if(secilendegerler.Count>0)
            {
                lstİllerA.DoDragDrop(lstİllerA, DragDropEffects.Move);

            }

        }

        private void lstİllerB_DragOver(object sender, DragEventArgs e)
        {
            var tasımadegerlervarmi = e.Data.GetDataPresent(typeof(ListBox).FullName) ;
            var tasınandegerler = e.Data.GetData(typeof(ListBox).FullName) as ListBox;
            if(tasımadegerlervarmi == true)
            {
                e.Effect = DragDropEffects.Move;

            }
            else
            {
                e.Effect= DragDropEffects.None;
            }
        }

        private void lstİllerB_DragDrop(object sender, DragEventArgs e)
        {
            var tasımavarmı =e.Data.GetDataPresent(typeof (ListBox).FullName) ;
            var tasınandegerler = e.Data.GetData(typeof(ListBox).FullName)as ListBox;
            if(tasımavarmı == true)
            {
                var degerler = tasınandegerler.SelectedItems;
                foreach( var deger in degerler )
                {
                    lstİllerB.Items.Add(deger);

                }
                var secılenindexler = tasınandegerler.SelectedIndices;
                for(var i=secılenindexler.Count -1; i>=0 ; i--)
                {
                    lstİllerA.Items.RemoveAt(secılenindexler[i]);
                }
            }



        }

        private void lstİllerA_DragDrop(object sender, DragEventArgs e)
        {
            var tasinanListBox = e.Data.GetData(typeof(ListBox).FullName) as ListBox;
            if (tasinanListBox != null)
            {
                foreach (var deger in tasinanListBox.SelectedItems)
                {
                    lstİllerA.Items.Add(deger);
                }

                for (int i=tasinanListBox.SelectedIndices.Count -1; i>=0 ; i--)
                {
                    tasinanListBox.Items.RemoveAt(tasinanListBox.SelectedIndices[i]); 
                }
            }
        }

        private void lstİllerA_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lstİllerB_MouseDown(object sender, MouseEventArgs e)
        {
            if(lstİllerB.SelectedItems.Count>0)
            {
                lstİllerB.DoDragDrop(lstİllerB, DragDropEffects.Move);
            }
        }
    }
}
