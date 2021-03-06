﻿using FLifegame.Common;
using System;
using System.ComponentModel;

namespace FLifegame.Model
{
    public class Cell : INotifyPropertyChanged, ICloneable<Cell>
    {
        public event PropertyChangedEventHandler PropertyChanged;

        bool on = false;

        public bool On
        {
            get { return on; }
            set {
                if (value != on) {
                    on = value;
                    PropertyChanged.Raise(this);
                }
            }
        }
        
        public Cell Clone()
        { return new Cell { On = On }; }

        public void Invert()
        { On = !On; }
    }
}
