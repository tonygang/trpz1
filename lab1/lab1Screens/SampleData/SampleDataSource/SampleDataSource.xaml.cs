﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.SampleDataSource
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class SampleDataSource { }
#else

	public class SampleDataSource : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public SampleDataSource()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/lab1.Screens;component/SampleData/SampleDataSource/SampleDataSource.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private Books _Books = new Books();

		public Books Books
		{
			get
			{
				return this._Books;
			}
		}
	}

	public class Books : System.Collections.ObjectModel.ObservableCollection<BooksItem>
	{ 
	}

	public class BooksItem : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private double _Property1 = 0;

		public double Property1
		{
			get
			{
				return this._Property1;
			}

			set
			{
				if (this._Property1 != value)
				{
					this._Property1 = value;
					this.OnPropertyChanged("Property1");
				}
			}
		}

		private System.Windows.Media.ImageSource _Property2 = null;

		public System.Windows.Media.ImageSource Property2
		{
			get
			{
				return this._Property2;
			}

			set
			{
				if (this._Property2 != value)
				{
					this._Property2 = value;
					this.OnPropertyChanged("Property2");
				}
			}
		}

		private string _Property3 = string.Empty;

		public string Property3
		{
			get
			{
				return this._Property3;
			}

			set
			{
				if (this._Property3 != value)
				{
					this._Property3 = value;
					this.OnPropertyChanged("Property3");
				}
			}
		}

		private string _Property4 = string.Empty;

		public string Property4
		{
			get
			{
				return this._Property4;
			}

			set
			{
				if (this._Property4 != value)
				{
					this._Property4 = value;
					this.OnPropertyChanged("Property4");
				}
			}
		}
	}
#endif
}
