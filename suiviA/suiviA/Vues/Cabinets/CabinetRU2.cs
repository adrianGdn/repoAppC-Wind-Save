using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes_Metiers;
using Classe_Passerelle;

namespace Vues.Cabinets
{
    public partial class CabinetRU2 : Form
    {
        public CabinetRU2()
        {
            InitializeComponent();
        }

        private static List<Cabinet> uneListeDeCabinet;
        private static List<Acteur> uneListeDeVisiteur;
        private static List<Medecin> uneListeDeMedecin;
        private String cpSelectionne;
        private String villeSelectionnee;
        private Medecin medecinSelectionne;
        private Cabinet cabinetSelectionne;

        private void CabinetRU2_Load(object sender, EventArgs e)
        {
            // Initialise les listes
            uneListeDeCabinet = PasserelleSuiviA.initListeCabinet();
            uneListeDeVisiteur = PasserelleSuiviA.initListeActeur();
            uneListeDeMedecin = PasserelleSuiviA.initListeMedecin();

            // Met les éléments dans le cbox Ville
            foreach (Cabinet unCabinet in uneListeDeCabinet)
            {
                if (!cboxVille.Items.Contains(unCabinet.getVille()))
                {
                    cboxVille.Items.Add(unCabinet.getVille());
                }
            }

            //Ajout des éléments dans le combobox Code Postal
            foreach (Cabinet unCabinet in uneListeDeCabinet)
            {
                if (!cboxCP.Items.Contains(unCabinet.getNumDepartement()))
                {
                    cboxCP.Items.Add(unCabinet.getNumDepartement());
                }
            }

            //Ajout des éléments dans le combobox Médecin
            foreach (Medecin leMedecin in uneListeDeMedecin)
            {
                cboxMedecin.Items.Add(leMedecin);
            }


            //Ajout des éléments dans le combobox Cabinet
            foreach (Cabinet leCabinet in uneListeDeCabinet)
            {
                cboxCabinet.Items.Add(leCabinet);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if(cboxCabinet.SelectedItem != null)
            {
                PasserelleSuiviA.setCabinetAModifier((Cabinet)cboxCabinet.SelectedItem);
                ModifierCabinet MC = new ModifierCabinet();
                MC.Show();
            }
        }

        private void cboxCP_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpSelectionne = (String)cboxCP.SelectedItem;

            //Filtre des médecins selon le code postal sélectionné
            cboxCabinet.Items.Clear();
            // Remplir le combobox avec les cabinet filtrés
            foreach (Cabinet unCabinet in uneListeDeCabinet)
            {
                String cpDuCabinet = unCabinet.getCP();
                if (cpDuCabinet.Substring(0,2) == cpSelectionne)
                    cboxCabinet.Items.Add(unCabinet);
            }
        }

        private void cboxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            villeSelectionnee = (String)cboxVille.SelectedItem;
            //Filtre des médecins selon la ville sélectionnée
            cboxCabinet.Items.Clear();
            // Remplir le combobox avec les cabinet filtrés
            foreach (Cabinet unCabinet in uneListeDeCabinet)
            {
                String villeDuCabinet = unCabinet.getVille();
                if (villeDuCabinet == villeSelectionnee)
                    cboxCabinet.Items.Add(unCabinet);
            }
        }

        private void cboxMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            medecinSelectionne = (Medecin)cboxMedecin.SelectedItem;
            //Filtre des médecins selon le médecin sélectionné
            cboxCabinet.Items.Clear();
            // Remplir le combobox avec les cabinet filtrés
            foreach(Cabinet unCabinet in uneListeDeCabinet)
            {
                if (unCabinet == medecinSelectionne.getLeCabinet())
                    cboxCabinet.Items.Add(unCabinet);
            }
        }

        private void cboxCabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cabinetSelectionne = (Cabinet)cboxCabinet.SelectedItem;
            txtAdresse.Text = cabinetSelectionne.getRue();
            txtCP.Text = cabinetSelectionne.getCP();
            txtVille.Text = cabinetSelectionne.getVille();
        }
    }
}
