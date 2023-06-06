using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace BM23.Pages
{

    public interface IButtonScaler
    {
        void SetButtonScale();
        void IncreaseButtonScale(ImageButton ImageButton);
    }

    public partial class TeamSelect : ContentPage, IButtonScaler
    {
        List<ImageButton> ImageButtonList;

        public TeamSelect()
        {
            InitializeComponent();

            ImageButtonList = new List<ImageButton>
            {
                bostonBtn,
                milwaukeeBtn,
                miamiBtn,
                denverBtn,
                sacramentoBtn,
                memphisBtn,
                philadelphiaBtn,
                clevelandBtn,
                atlantaBtn,
                minnesotaBtn,
                phoenixBtn,
                newOrleansBtn,
                newYorkBtn,
                chicagoBtn,
                washingtonBtn,
                oklahomaBtn,
                goldenStateBtn,
                dallasBtn,
                brooklynBtn,
                indianaBtn,
                orlandoBtn,
                utahBtn,
                laClippersBtn,
                houstonBtn,
                torontoBtn,
                detroitBtn,
                charlotteBtn,
                portlandBtn,
                laLakersBtn,
                sanAntonioBtn,
            };

            ContinueBtn.IsEnabled = false;

            foreach (var ImageButton in ImageButtonList)
            {
                ImageButton.Clicked += ImageButton_Clicked;
            }
        }

        public void SetButtonScale()
        {
            foreach (var button in ImageButtonList)
            {
                button.Scale = 0.7;
            }
        }

        public void IncreaseButtonScale(ImageButton ImageButton)
        {
            ImageButton.Scale = 1.05;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            SetButtonScale();

            if (sender is ImageButton clickedImageButton)
            {
                IncreaseButtonScale(clickedImageButton);
                var clickedButton = (ImageButton)sender;
                ContinueBtn.IsEnabled = true;
            }
        }

        void ContinueBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Hub());
        }
    }
}