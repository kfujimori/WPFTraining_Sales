/**************************************************
Warning!
This code is automatically created.
If you change this file manually, you may lose the edited contents.
**************************************************/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sales
{
    class ResultT4 : INotifyPropertyChanged
    {

        private readonly ValidationContext _validationContext;
        public event PropertyChangedEventHandler PropertyChanged;

        public ResultT4()
        {

            _validationContext = new ValidationContext(this, null, null);

            
            Id = 1;

            
            Date = DateTime.Today;

            
            SectionId = 1;

            
            Title = string.Empty;

            
            Price = 1;

                    }

        public void SetProperties(ResultT4 source)
        {
            
            Id = source.Id;

            
            Date = source.Date;

            
            SectionId = source.SectionId;

            
            Title = source.Title;

            
            Price = source.Price;

                    }

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        
        private int _Id ;
        
        public int Id {
            get { return _Id; }
            set {
                if (Id == value) return;
                _validationContext.MemberName = "Id";
                Validator.ValidateProperty(value, _validationContext);
                _Id = value;
                RaisePropertyChanged("Id");
            }
        }

        
        private DateTime _Date ;
        
        public DateTime Date {
            get { return _Date; }
            set {
                if (Date == value) return;
                _validationContext.MemberName = "Date";
                Validator.ValidateProperty(value, _validationContext);
                _Date = value;
                RaisePropertyChanged("Date");
            }
        }

        
        private byte _SectionId ;
        [Range(1,byte.MaxValue, ErrorMessage="without valid range !")]
        public byte SectionId {
            get { return _SectionId; }
            set {
                if (SectionId == value) return;
                _validationContext.MemberName = "SectionId";
                Validator.ValidateProperty(value, _validationContext);
                _SectionId = value;
                RaisePropertyChanged("SectionId");
            }
        }

        
        private string _Title ;
        [StringLength(32,ErrorMessage="too long ! !")]
        public string Title {
            get { return _Title; }
            set {
                if (Title == value) return;
                _validationContext.MemberName = "Title";
                Validator.ValidateProperty(value, _validationContext);
                _Title = value;
                RaisePropertyChanged("Title");
            }
        }

        
        private int _Price ;
        [Range(1,9999999, ErrorMessage="without valid range !")]
        public int Price {
            get { return _Price; }
            set {
                if (Price == value) return;
                _validationContext.MemberName = "Price";
                Validator.ValidateProperty(value, _validationContext);
                _Price = value;
                RaisePropertyChanged("Price");
            }
        }

        


    }
}



