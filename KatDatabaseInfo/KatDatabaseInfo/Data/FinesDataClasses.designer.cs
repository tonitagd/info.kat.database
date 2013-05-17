﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KatDatabaseInfo.Data
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
	public partial class FinesDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFine(Fine instance);
    partial void UpdateFine(Fine instance);
    partial void DeleteFine(Fine instance);
    #endregion
		
		public FinesDataClassesDataContext() : 
				base(global::KatDatabaseInfo.Properties.Settings.Default.DatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public FinesDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FinesDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FinesDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FinesDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Fine> Fines
		{
			get
			{
				return this.GetTable<Fine>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddNewFine")]
		public int AddNewFine([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Type", DbType="NVarChar(10)")] string type, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SerialNumber", DbType="NVarChar(50)")] string serialNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Date", DbType="NVarChar(50)")] string date, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Policeman", DbType="NVarChar(50)")] string policeman, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DrivingLicenseNumber", DbType="NChar(10)")] string drivingLicenseNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Paid", DbType="TinyInt")] System.Nullable<byte> paid, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Reason", DbType="NVarChar(100)")] string reason, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Amount", DbType="Money")] System.Nullable<decimal> amount, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Location", DbType="NVarChar(250)")] string location, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hour", DbType="NVarChar(10)")] string hour)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), type, serialNumber, date, policeman, drivingLicenseNumber, paid, reason, amount, location, hour);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Fines")]
	public partial class Fine : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Type;
		
		private string _SerialNumber;
		
		private string _Date;
		
		private string _Policeman;
		
		private string _DrivingLicenseNumber;
		
		private byte _Paid;
		
		private string _Reason;
		
		private System.Nullable<decimal> _Amount;
		
		private string _Location;
		
		private string _Hour;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnSerialNumberChanging(string value);
    partial void OnSerialNumberChanged();
    partial void OnDateChanging(string value);
    partial void OnDateChanged();
    partial void OnPolicemanChanging(string value);
    partial void OnPolicemanChanged();
    partial void OnDrivingLicenseNumberChanging(string value);
    partial void OnDrivingLicenseNumberChanged();
    partial void OnPaidChanging(byte value);
    partial void OnPaidChanged();
    partial void OnReasonChanging(string value);
    partial void OnReasonChanged();
    partial void OnAmountChanging(System.Nullable<decimal> value);
    partial void OnAmountChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    partial void OnHourChanging(string value);
    partial void OnHourChanged();
    #endregion
		
		public Fine()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SerialNumber", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SerialNumber
		{
			get
			{
				return this._SerialNumber;
			}
			set
			{
				if ((this._SerialNumber != value))
				{
					this.OnSerialNumberChanging(value);
					this.SendPropertyChanging();
					this._SerialNumber = value;
					this.SendPropertyChanged("SerialNumber");
					this.OnSerialNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Policeman", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Policeman
		{
			get
			{
				return this._Policeman;
			}
			set
			{
				if ((this._Policeman != value))
				{
					this.OnPolicemanChanging(value);
					this.SendPropertyChanging();
					this._Policeman = value;
					this.SendPropertyChanged("Policeman");
					this.OnPolicemanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DrivingLicenseNumber", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string DrivingLicenseNumber
		{
			get
			{
				return this._DrivingLicenseNumber;
			}
			set
			{
				if ((this._DrivingLicenseNumber != value))
				{
					this.OnDrivingLicenseNumberChanging(value);
					this.SendPropertyChanging();
					this._DrivingLicenseNumber = value;
					this.SendPropertyChanged("DrivingLicenseNumber");
					this.OnDrivingLicenseNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Paid", DbType="TinyInt NOT NULL")]
		public byte Paid
		{
			get
			{
				return this._Paid;
			}
			set
			{
				if ((this._Paid != value))
				{
					this.OnPaidChanging(value);
					this.SendPropertyChanging();
					this._Paid = value;
					this.SendPropertyChanged("Paid");
					this.OnPaidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Reason", DbType="NVarChar(100)")]
		public string Reason
		{
			get
			{
				return this._Reason;
			}
			set
			{
				if ((this._Reason != value))
				{
					this.OnReasonChanging(value);
					this.SendPropertyChanging();
					this._Reason = value;
					this.SendPropertyChanged("Reason");
					this.OnReasonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Money")]
		public System.Nullable<decimal> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="NVarChar(250)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this.OnLocationChanging(value);
					this.SendPropertyChanging();
					this._Location = value;
					this.SendPropertyChanged("Location");
					this.OnLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hour", DbType="NVarChar(10)")]
		public string Hour
		{
			get
			{
				return this._Hour;
			}
			set
			{
				if ((this._Hour != value))
				{
					this.OnHourChanging(value);
					this.SendPropertyChanging();
					this._Hour = value;
					this.SendPropertyChanged("Hour");
					this.OnHourChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
