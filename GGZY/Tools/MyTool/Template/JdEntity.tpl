﻿using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类@(Model.ClassName)。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("@Model.TableName")]
    [Serializable]
    public partial class @Model.ClassName : JdEntity
    {
        #region Model
@foreach(var item in Model.Columns)
{
var typeName=item.TypeName;
if(typeName=="DateTime"||typeName=="DateTime?"){typeName="DateTime?";}
if(typeName=="int"){typeName="decimal?";}
if(typeName=="int?"){typeName="decimal?";}
		@:private @typeName _@item.ColumnName;
}

@foreach(var item in Model.Columns)
{
var typeName=item.TypeName;
if(typeName=="DateTime"||typeName=="DateTime?"){typeName="DateTime?";}
if(typeName=="int"){typeName="decimal?";}
if(typeName=="int?"){typeName="decimal?";}
		@:/// <summary>
		@:/// @(item.DeText)
		@:/// </summary>
		@:public @typeName @item.ColumnName
		@:{
			@:get{ return _@item.ColumnName; }
			@:set
			@:{
				@:this.OnPropertyValueChange(_.@item.ColumnName, _@item.ColumnName, value);
				@:this._@item.ColumnName = value;
			@:}
		@:}
}
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
@foreach(var item in Model.PrimaryKeyColumns)
{
				@:_.@item.ColumnName,
}
			};
        }
@if(Model.IdentityColumn != null)
{
		@:/// <summary>
        @:/// 获取实体中的标识列
        @:/// </summary>
        @:public override Field GetIdentityField()
        @:{
            @:return _.@Model.IdentityColumn.ColumnName;
        @:}
}
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
@foreach(var item in Model.Columns)
{
				@:_.@item.ColumnName,
}
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
@foreach(var item in Model.Columns)
{
				@:this._@item.ColumnName,
}
			};
        }
        #endregion

		#region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "@Model.TableName");
@foreach(var item in Model.Columns)
{
            @:/// <summary>
			@:/// @item.DeText
			@:/// </summary>
if(item.DbTypeName=="CLOB"){
			@:public readonly static Field @item.ColumnName = new Field("@item.ColumnNameRealName", "@Model.TableName",DbType.AnsiString, null, "@item.DeText");
}else{
			@:public readonly static Field @item.ColumnName = new Field("@item.ColumnNameRealName", "@Model.TableName", "@item.DeText");
}
}
        }
        #endregion
	}
}