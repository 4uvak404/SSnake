using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSnake
{
    internal class Record
    {
        public int Id { get; set; }
        public string? NickName { get; set; }
        public int Score { get; set; }
        public DateTime TimePassed { get; set; }
        public int MapWidth { get; set; }
        public int MapHeight { get; set; }
        public string? SpeedName { get; set; }
        public double SpeedValue { get; set; }
        public DateTime RecordDateTime { get; set; }
        public int SnakeLength { get; set; }

    }
}
