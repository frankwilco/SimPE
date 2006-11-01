using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimPe.PackedFiles.Wrapper
{
    public partial class PetTraitSelect : UserControl
    {
        public enum Levels { High, Normal, Low };
        
        public PetTraitSelect()
        {            
            InitializeComponent();

            Level = Levels.Normal;
        }

        public Levels Level
        {
            get
            {
                if (rb1.Checked) return Levels.High;
                if (rb3.Checked) return Levels.Low;
                return Levels.Normal;
            }
            set
            {
                if (value == Levels.High) rb1.Checked = true;
                else if (value == Levels.Low) rb3.Checked = true;
                else rb2.Checked = true;
            }
        }

        public event EventHandler LevelChanged;
        private void CheckedChanged(object sender, EventArgs e)
        {
            if (LevelChanged != null) LevelChanged(this, new EventArgs());
        }

        public void UpdateTraits(int high, int low, PetTraits traits)
        {
            if (traits == null) return;
            Levels lv = Level;
            traits.SetTrait(high, false);
            traits.SetTrait(low, false);
            if (lv == Levels.High) traits.SetTrait(high, true);
            if (lv == Levels.Low) traits.SetTrait(low, true);
        }

        public void SetTraitLevel(int high, int low, PetTraits traits)
        {
            if (traits == null) return;
            if (traits.GetTrait(high)) Level = Levels.High;
            else if (traits.GetTrait(low)) Level = Levels.Low;
            else Level = Levels.Normal;
        }
    }
}
