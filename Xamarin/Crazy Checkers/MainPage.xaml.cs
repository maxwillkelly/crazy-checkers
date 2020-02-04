using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Crazy_Checkers
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        const uint colSize = 8;
        const uint rowSize = 8;
        const int colLength = 50;
        const int rowLength = 50;

        Button[,] BtnArray;

        public MainPage()
        {
            InitializeComponent();
            WidthRequest = 800;
            HeightRequest = 800;
            CreateBtnGrid();
            SizeChanged += MainPage_SizeChanged;
        }

        private void CreateBtnGrid()
        {
            // Initialises the 2D array of buttons
            BtnArray = new Button[colSize, rowSize];
            Grid grid = new Grid();
            ColumnDefinition colDef = new ColumnDefinition();
            RowDefinition rowDef = new RowDefinition();
            rowDef.SizeChanged += RowDef_SizeChanged;
            grid.ColumnDefinitions.Add(colDef);
            grid.RowDefinitions.Add(rowDef);
            Content = grid;

            for (uint col = 0; col < colSize; col++)
            {
                for (uint row = 0; row < rowSize; row++)
                {
                    // Places button in array
                    Button btn = BtnArray[col, row];
                    // Creates button
                    btn = new Button();
                    // Adds event handler
                    btn.Pressed += BtnClick;
                    btn.ClassId = "Btn_" + col + "_" + row;
                    //
                    btn.FontSize = 35;
                    btn.Text = "⬤";
                    //
                    btn.WidthRequest = 100;
                    btn.HeightRequest = 100;
                    btn.VerticalOptions = LayoutOptions.FillAndExpand;
                    btn.HorizontalOptions = LayoutOptions.FillAndExpand;
                    //
                    grid.Children.Add(btn, Convert.ToInt32(col), Convert.ToInt32(row));
                }
            }
    }



        private void RowDef_SizeChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnClick(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            System.Diagnostics.Debug.WriteLine(btn.ClassId);
            /*
             * Button btnCompare = BtnArray[0,0];
             * while(btn != btnCompare) {}
             */  
        }

        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            // ApplicationView.GetForCurrentView().TryResizeView(new Size(800, 800));
        }
    }
}
