using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEğitimKampı301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

       EgitimKampı301EfTravelDbEntities db = new EgitimKampı301EfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {

            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.LocationCapacity).ToString();
            lblGuideCount.Text = db.Location.Count().ToString();
            llblAvgCapacity.Text = db.Location.Average(x => x.LocationCapacity).ToString();
            lblAvgLocationPrice.Text = ((double)db.Location.Average(x => x.LocationPrice)).ToString("N0") + " ₺";

            int LastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x =>x.LocationId == LastCountryId).Select(y=>y.LocationCountry).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.LocationCity == "Kapadokya").Select(y => y.LocationCapacity).FirstOrDefault().ToString();                       


            lblTurkiyeCapacityAvg.Text=db.Location.Where(x=>x.LocationCountry == "Türkiye").Average(y=>y.LocationCapacity).ToString();

            var romaGuideId=db.Location.Where(x=>x.LocationCity=="Roma").Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text =db.Guide.Where(x=>x.GuideId==romaGuideId).Select(y=>y.GuideName +" "+y.GuideSurname).FirstOrDefault().ToString();

           var maxCapacity=db.Location.Max(x=>x.LocationCapacity);
            lblMaxCapacityLocation.Text=db.Location.Where(x=> x.LocationCapacity == maxCapacity).Select(y=>y.LocationCity).FirstOrDefault().ToString();

            var maxPrice=db.Location.Max(x=>x.LocationPrice);
            lblMaxPriceLocation.Text = db.Location.Where(x=> x.LocationPrice==maxPrice).Select(y=>y.LocationCity).FirstOrDefault().ToString();   


            var GuideIdByNameHuseyinAkyol=db.Guide.Where(x=>x.GuideName=="Hüseyin" & x.GuideSurname=="Akyol").Select(y=>y.GuideId).FirstOrDefault();
            lblHuseyinAkyolLocationCount.Text=db.Location.Where(x=>x.GuideId==GuideIdByNameHuseyinAkyol).Count().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaMenü frmAnaMenü = new FrmAnaMenü();
            frmAnaMenü.Show();

            this.Hide();
        }
    }
}
