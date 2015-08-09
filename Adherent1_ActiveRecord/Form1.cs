using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adherent1_ActiveRecord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Adherent> lesAdherents = Adherent.GetAllAdherent();

            //Exemple d'affichage dans une listView. La listView s'appelle listViewAdherent.
            foreach (var item in lesAdherents)
            {
                
                ListViewItem listItem = new ListViewItem(item.GetNom());
                listItem.SubItems.Add(item.GetPrenom());
                listItem.SubItems.Add(item.GetVille());
                listItem.SubItems.Add(item.GetCodePostal());
                listItem.SubItems.Add(item.GetDateDeNaissance().ToShortDateString());

                listViewAdherents.Items.Add(listItem);

            }

      
            //Exemple de création d'un nouvel adhérent dans la base
            Adherent unNouvelAdherent = new Adherent("Ryan", "Giggs", "4675", "Manchester", new DateTime(1960, 5, 6), 1);
            unNouvelAdherent.Save();
            
            //Exemple de modification d'un adhérent dans la base. On modifie l'adhérent avec un id de 6
            Adherent adherentModification = Adherent.GetAdherent(6);
            adherentModification.SetVille("Tottenham");
            adherentModification.Save();
            

        }
    }
}
