using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crazy_Checkers
{
    // Creates a Grid based on the Windows Form Class TableLayoutPanel
    public class Grid : TableLayoutPanel
    {
        public event EventHandler BtnEventHandler;
        // Stores each position so they can be accessed
        private Position[,] PositionArray;

        // /* COMMENTS AREA
        // We need to:
        //     - set up a way to get the state of a piece selected
        //     - set up a way to set the state of a piece

        // We have done:
        //     -     
        
        // */

        public Grid(uint colSize, uint rowSize)
        {
            // Adds dimesnions from parameters
            ColumnCount = Convert.ToInt32(colSize);
            RowCount = Convert.ToInt32(rowSize);
            // Allows the buttons to change with size of the grid
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoSize = true;
            Dock = DockStyle.Fill;
            // Names the object for referencing
            Name = "Grid";
            // Sets the location of the Grid
            Location = new Point(0, 50);
            // Eliminates seperation between buttons
            Margin = new Padding(0);
            // Sets the default size of the grid
            Size = new Size(512, 512);
            // Sets up the grid with the appropriate dimensions
            SetupGridStyles();
            // Initalises a 2D array to store each position
            PositionArray = new Position[colSize, rowSize];
            // Populates each position with buttons
            CreateBtnGrid();
            // Sets the first two and back two rows of the grid to belong to one player or another
            SquareColor();
            SetupInitalPositions();
        }

        // Sets up the grid with the appropriate dimensions
        private void SetupGridStyles()
        {
            // Loops through each column
            for (uint i = 0; i < ColumnCount; i++)
            {
                // Adds a column style which gives each column an equal amount of space
                ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / ColumnCount));
            }
            // Loops through each row
            for (uint i = 0; i < RowCount; i++)
            {
                // Adds a row style which gives each column an equal amount of space
                RowStyles.Add(new RowStyle(SizeType.Percent, 100 / RowCount));
            }
        }

        // Populates each position on the grid with buttons
        private void CreateBtnGrid()
        {
            // Loops through each position
            for (uint col = 0; col < ColumnCount; col++)
            {
                for (uint row = 0; row < RowCount; row++)
                {
                    // Places button in array
                    ref Position btn = ref PositionArray[col, row];
                    // Creates button
                    btn = new Position(col, row, 2);
                    // Adds button to Main form
                    Controls.Add(btn, Convert.ToInt32(col), Convert.ToInt32(row));
                    // Adds button event handler
                    btn.Click += new EventHandler(BtnClick);
                }
            }
        }

        // Sets the first two and back two rows of the grid to belong to one player or another 
        public void SetupInitalPositions()
        {
            for (uint i = 0; i < ColumnCount; i++)
            {
                for (uint j = 0; j < 3; j++)
                {
                    Position pos = GetPosition(i,j);
                    if (pos.SquareColor == 1) {
                        SetPosition(i, j, 0, false);
                    }
                }
            }

            for (uint i = 0; i < ColumnCount; i++)
            {
                for (uint j = Convert.ToUInt32(RowCount - 3); j < RowCount; j++)
                {
                    Position pos = GetPosition(i,j);
                    if (pos.SquareColor == 1) {
                        SetPosition(i, j, 1, false);
                    }
                }
            }
        }

        // Returns a reference to a position
        public ref Position GetPosition(uint col, uint row)
        {
            return ref PositionArray[col, row];
        }

        // Can be used to set all values of a position
        public void SetPosition(uint col, uint row, uint color, bool isKing)
        {
            // Checks for invalid dimensions
            if (col >= ColumnCount || row >= RowCount)
            {
                throw new Exception("A position was attempted to be set outside of the current dimensions");
            }
            // Checks for invalid color
            else if (color > 2)
            {
                throw new Exception("A position was attempted to be set with an invalid colour");
            }
            else
            {
                PositionArray[col, row].Color = color;
                PositionArray[col, row].isKing = isKing;
            }
        }

        // Event Handler for clicking a position
        public void BtnClick(object sender, EventArgs e)
        {
            BtnEventHandler(sender, e);
        }

        // private Square[,] square;

        // public Grid()
        // {
        //     InitializeComponent();
        //     int i, j;
        //     this.square = new Square[8, 8];
            
        //     for (i = 0; i < 8; i++)
        //     {
        //         for (j = 0; j < 8; j++)
        //         {
        //             this.square[i, j] = new Square();
        //             this.square[i, j].BackColor = System.Drawing.SystemColors.ActiveCaption; 
        //             this.square[i, j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; 
        //             this.square[i, j].Location = new System.Drawing.Point(57 + i * 40, 109 + j * 40); 
        //             this.square[i, j].Name = "pictureBox1"; 
        //             this.square[i, j].Size = new System.Drawing.Size(40, 40); 
        //             this.square[i, j].TabIndex = 2; 
        //             this.square[i, j].TabStop = false; 
        //             this.Controls.Add(this.square[i, j]);
        //         }
        //     }
        // }

        private void SquareColor() {

            for (uint i = 1; i < ColumnCount; i+=2)
            {
                for (uint j = 0; j < RowCount; j+=2)
                {
                    PositionArray[i,j].SquareColor = 1;
                }
            }

            for (uint i = 0; i < ColumnCount; i+=2)
            {
                for (uint j = 1; j < RowCount; j+=2)
                {
                    PositionArray[i,j].SquareColor = 1;
                }
            }
        }
    }
}
