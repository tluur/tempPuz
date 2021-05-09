using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Xamarin.Forms;

namespace XamagonXuzzle
{
	public class Tile
	{
        const string UrlPrefix = "http://www.tlu.ee/~tluur/img/";

        public Tile(int row, int col)
        {
            Row = row;
            Col = col;
            Random random = new Random();
            int randomNumber = random.Next(1, 3);

            TileView = new ContentView
            {
                Padding = new Thickness(1),

                // Get the bitmap for each tile 
                Content = new Image
                {
                    Source = ImageSource.FromUri(new Uri(UrlPrefix + randomNumber + "/Bitmap" + row + col + ".jpg"))
                }
            };

            // Add TileView to dictionary for obtaining Tile from TileView
            Dictionary.Add(TileView, this);
        }

        public static Dictionary<View, Tile> Dictionary { get; } = new Dictionary<View, Tile>();

        public int Row { set; get; }

        public int Col { set; get; }

        public View TileView { private set; get; }
    }
}