﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookbook.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="aspnet-Cookbook-20130302154948")]
	public partial class CookbookDBModelsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBlogPost(BlogPost instance);
    partial void UpdateBlogPost(BlogPost instance);
    partial void DeleteBlogPost(BlogPost instance);
    partial void InsertComment(Comment instance);
    partial void UpdateComment(Comment instance);
    partial void DeleteComment(Comment instance);
    partial void InsertImage(Image instance);
    partial void UpdateImage(Image instance);
    partial void DeleteImage(Image instance);
    partial void InsertIngredient(Ingredient instance);
    partial void UpdateIngredient(Ingredient instance);
    partial void DeleteIngredient(Ingredient instance);
    partial void InsertRecipe(Recipe instance);
    partial void UpdateRecipe(Recipe instance);
    partial void DeleteRecipe(Recipe instance);
    #endregion
		
		public CookbookDBModelsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["aspnet_Cookbook_20130302154948ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CookbookDBModelsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CookbookDBModelsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CookbookDBModelsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CookbookDBModelsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BlogPost> BlogPosts
		{
			get
			{
				return this.GetTable<BlogPost>();
			}
		}
		
		public System.Data.Linq.Table<BlogPost_Comment> BlogPost_Comments
		{
			get
			{
				return this.GetTable<BlogPost_Comment>();
			}
		}
		
		public System.Data.Linq.Table<BlogPost_Image> BlogPost_Images
		{
			get
			{
				return this.GetTable<BlogPost_Image>();
			}
		}
		
		public System.Data.Linq.Table<BlogPost_Liker> BlogPost_Likers
		{
			get
			{
				return this.GetTable<BlogPost_Liker>();
			}
		}
		
		public System.Data.Linq.Table<BlogPost_Tag> BlogPost_Tags
		{
			get
			{
				return this.GetTable<BlogPost_Tag>();
			}
		}
		
		public System.Data.Linq.Table<Comment> Comments
		{
			get
			{
				return this.GetTable<Comment>();
			}
		}
		
		public System.Data.Linq.Table<Image> Images
		{
			get
			{
				return this.GetTable<Image>();
			}
		}
		
		public System.Data.Linq.Table<Ingredient> Ingredients
		{
			get
			{
				return this.GetTable<Ingredient>();
			}
		}
		
		public System.Data.Linq.Table<Recipe> Recipes
		{
			get
			{
				return this.GetTable<Recipe>();
			}
		}
		
		public System.Data.Linq.Table<Recipe_Comment> Recipe_Comments
		{
			get
			{
				return this.GetTable<Recipe_Comment>();
			}
		}
		
		public System.Data.Linq.Table<Recipe_Favoriter> Recipe_Favoriters
		{
			get
			{
				return this.GetTable<Recipe_Favoriter>();
			}
		}
		
		public System.Data.Linq.Table<Recipe_Image> Recipe_Images
		{
			get
			{
				return this.GetTable<Recipe_Image>();
			}
		}
		
		public System.Data.Linq.Table<Recipe_Liker> Recipe_Likers
		{
			get
			{
				return this.GetTable<Recipe_Liker>();
			}
		}
		
		public System.Data.Linq.Table<Recipe_Tag> Recipe_Tags
		{
			get
			{
				return this.GetTable<Recipe_Tag>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BlogPost")]
	public partial class BlogPost : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BlogPostId;
		
		private int _UserId;
		
		private string _Title;
		
		private string _Post;
		
		private System.DateTime _DateCreated;
		
		private System.DateTime _DateModified;
		
		private int _LikeCount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBlogPostIdChanging(int value);
    partial void OnBlogPostIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnPostChanging(string value);
    partial void OnPostChanged();
    partial void OnDateCreatedChanging(System.DateTime value);
    partial void OnDateCreatedChanged();
    partial void OnDateModifiedChanging(System.DateTime value);
    partial void OnDateModifiedChanged();
    partial void OnLikeCountChanging(int value);
    partial void OnLikeCountChanged();
    #endregion
		
		public BlogPost()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BlogPostId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BlogPostId
		{
			get
			{
				return this._BlogPostId;
			}
			set
			{
				if ((this._BlogPostId != value))
				{
					this.OnBlogPostIdChanging(value);
					this.SendPropertyChanging();
					this._BlogPostId = value;
					this.SendPropertyChanged("BlogPostId");
					this.OnBlogPostIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Post", DbType="NVarChar(4000) NOT NULL", CanBeNull=false)]
		public string Post
		{
			get
			{
				return this._Post;
			}
			set
			{
				if ((this._Post != value))
				{
					this.OnPostChanging(value);
					this.SendPropertyChanging();
					this._Post = value;
					this.SendPropertyChanged("Post");
					this.OnPostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime NOT NULL")]
		public System.DateTime DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateModified", DbType="DateTime NOT NULL")]
		public System.DateTime DateModified
		{
			get
			{
				return this._DateModified;
			}
			set
			{
				if ((this._DateModified != value))
				{
					this.OnDateModifiedChanging(value);
					this.SendPropertyChanging();
					this._DateModified = value;
					this.SendPropertyChanged("DateModified");
					this.OnDateModifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LikeCount", DbType="Int NOT NULL")]
		public int LikeCount
		{
			get
			{
				return this._LikeCount;
			}
			set
			{
				if ((this._LikeCount != value))
				{
					this.OnLikeCountChanging(value);
					this.SendPropertyChanging();
					this._LikeCount = value;
					this.SendPropertyChanged("LikeCount");
					this.OnLikeCountChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BlogPost_Comment")]
	public partial class BlogPost_Comment
	{
		
		private int _BlogPostId;
		
		private int _CommentId;
		
		public BlogPost_Comment()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BlogPostId", DbType="Int NOT NULL")]
		public int BlogPostId
		{
			get
			{
				return this._BlogPostId;
			}
			set
			{
				if ((this._BlogPostId != value))
				{
					this._BlogPostId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentId", DbType="Int NOT NULL")]
		public int CommentId
		{
			get
			{
				return this._CommentId;
			}
			set
			{
				if ((this._CommentId != value))
				{
					this._CommentId = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BlogPost_Image")]
	public partial class BlogPost_Image
	{
		
		private int _BlogPostId;
		
		private int _ImageId;
		
		public BlogPost_Image()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BlogPostId", DbType="Int NOT NULL")]
		public int BlogPostId
		{
			get
			{
				return this._BlogPostId;
			}
			set
			{
				if ((this._BlogPostId != value))
				{
					this._BlogPostId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageId", DbType="Int NOT NULL")]
		public int ImageId
		{
			get
			{
				return this._ImageId;
			}
			set
			{
				if ((this._ImageId != value))
				{
					this._ImageId = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BlogPost_Liker")]
	public partial class BlogPost_Liker
	{
		
		private int _BlogPostId;
		
		private int _UserId;
		
		public BlogPost_Liker()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BlogPostId", DbType="Int NOT NULL")]
		public int BlogPostId
		{
			get
			{
				return this._BlogPostId;
			}
			set
			{
				if ((this._BlogPostId != value))
				{
					this._BlogPostId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this._UserId = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BlogPost_Tag")]
	public partial class BlogPost_Tag
	{
		
		private int _BlogPostId;
		
		private string _Tag;
		
		public BlogPost_Tag()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BlogPostId", DbType="Int NOT NULL")]
		public int BlogPostId
		{
			get
			{
				return this._BlogPostId;
			}
			set
			{
				if ((this._BlogPostId != value))
				{
					this._BlogPostId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tag", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Tag
		{
			get
			{
				return this._Tag;
			}
			set
			{
				if ((this._Tag != value))
				{
					this._Tag = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Comment")]
	public partial class Comment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CommentId;
		
		private int _UserId;
		
		private string _Content;
		
		private System.DateTime _DateCreated;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCommentIdChanging(int value);
    partial void OnCommentIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnContentChanging(string value);
    partial void OnContentChanged();
    partial void OnDateCreatedChanging(System.DateTime value);
    partial void OnDateCreatedChanged();
    #endregion
		
		public Comment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CommentId
		{
			get
			{
				return this._CommentId;
			}
			set
			{
				if ((this._CommentId != value))
				{
					this.OnCommentIdChanging(value);
					this.SendPropertyChanging();
					this._CommentId = value;
					this.SendPropertyChanged("CommentId");
					this.OnCommentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this.OnContentChanging(value);
					this.SendPropertyChanging();
					this._Content = value;
					this.SendPropertyChanged("Content");
					this.OnContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime NOT NULL")]
		public System.DateTime DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Image")]
	public partial class Image : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ImageId;
		
		private int _UserId;
		
		private string _ImageUrl;
		
		private string _ImageTitle;
		
		private string _ImageDescription;
		
		private System.DateTime _DateCreated;
		
		private System.Nullable<System.DateTime> _DateModified;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnImageIdChanging(int value);
    partial void OnImageIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnImageUrlChanging(string value);
    partial void OnImageUrlChanged();
    partial void OnImageTitleChanging(string value);
    partial void OnImageTitleChanged();
    partial void OnImageDescriptionChanging(string value);
    partial void OnImageDescriptionChanged();
    partial void OnDateCreatedChanging(System.DateTime value);
    partial void OnDateCreatedChanged();
    partial void OnDateModifiedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateModifiedChanged();
    #endregion
		
		public Image()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ImageId
		{
			get
			{
				return this._ImageId;
			}
			set
			{
				if ((this._ImageId != value))
				{
					this.OnImageIdChanging(value);
					this.SendPropertyChanging();
					this._ImageId = value;
					this.SendPropertyChanged("ImageId");
					this.OnImageIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageUrl", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string ImageUrl
		{
			get
			{
				return this._ImageUrl;
			}
			set
			{
				if ((this._ImageUrl != value))
				{
					this.OnImageUrlChanging(value);
					this.SendPropertyChanging();
					this._ImageUrl = value;
					this.SendPropertyChanged("ImageUrl");
					this.OnImageUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageTitle", DbType="NVarChar(150)")]
		public string ImageTitle
		{
			get
			{
				return this._ImageTitle;
			}
			set
			{
				if ((this._ImageTitle != value))
				{
					this.OnImageTitleChanging(value);
					this.SendPropertyChanging();
					this._ImageTitle = value;
					this.SendPropertyChanged("ImageTitle");
					this.OnImageTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageDescription", DbType="NVarChar(300)")]
		public string ImageDescription
		{
			get
			{
				return this._ImageDescription;
			}
			set
			{
				if ((this._ImageDescription != value))
				{
					this.OnImageDescriptionChanging(value);
					this.SendPropertyChanging();
					this._ImageDescription = value;
					this.SendPropertyChanged("ImageDescription");
					this.OnImageDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime NOT NULL")]
		public System.DateTime DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateModified", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateModified
		{
			get
			{
				return this._DateModified;
			}
			set
			{
				if ((this._DateModified != value))
				{
					this.OnDateModifiedChanging(value);
					this.SendPropertyChanging();
					this._DateModified = value;
					this.SendPropertyChanged("DateModified");
					this.OnDateModifiedChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ingredient")]
	public partial class Ingredient : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IngredientId;
		
		private int _RecipeId;
		
		private string _Quantity;
		
		private string _Name;
		
		private EntityRef<Recipe> _Recipe;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIngredientIdChanging(int value);
    partial void OnIngredientIdChanged();
    partial void OnRecipeIdChanging(int value);
    partial void OnRecipeIdChanged();
    partial void OnQuantityChanging(string value);
    partial void OnQuantityChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Ingredient()
		{
			this._Recipe = default(EntityRef<Recipe>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IngredientId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IngredientId
		{
			get
			{
				return this._IngredientId;
			}
			set
			{
				if ((this._IngredientId != value))
				{
					this.OnIngredientIdChanging(value);
					this.SendPropertyChanging();
					this._IngredientId = value;
					this.SendPropertyChanged("IngredientId");
					this.OnIngredientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipeId", DbType="Int NOT NULL")]
		public int RecipeId
		{
			get
			{
				return this._RecipeId;
			}
			set
			{
				if ((this._RecipeId != value))
				{
					if (this._Recipe.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRecipeIdChanging(value);
					this.SendPropertyChanging();
					this._RecipeId = value;
					this.SendPropertyChanged("RecipeId");
					this.OnRecipeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Recipe_Ingredient", Storage="_Recipe", ThisKey="RecipeId", OtherKey="RecipeID", IsForeignKey=true)]
		public Recipe Recipe
		{
			get
			{
				return this._Recipe.Entity;
			}
			set
			{
				Recipe previousValue = this._Recipe.Entity;
				if (((previousValue != value) 
							|| (this._Recipe.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Recipe.Entity = null;
						previousValue.Ingredients.Remove(this);
					}
					this._Recipe.Entity = value;
					if ((value != null))
					{
						value.Ingredients.Add(this);
						this._RecipeId = value.RecipeID;
					}
					else
					{
						this._RecipeId = default(int);
					}
					this.SendPropertyChanged("Recipe");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Recipe")]
	public partial class Recipe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RecipeID;
		
		private int _UserID;
		
		private string _Title;
		
		private string _Instructions;
		
		private System.DateTime _DateCreated;
		
		private System.DateTime _DateModified;
		
		private int _FavoriteCount;
		
		private int _LikeCount;
		
		private EntitySet<Ingredient> _Ingredients;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRecipeIDChanging(int value);
    partial void OnRecipeIDChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnInstructionsChanging(string value);
    partial void OnInstructionsChanged();
    partial void OnDateCreatedChanging(System.DateTime value);
    partial void OnDateCreatedChanged();
    partial void OnDateModifiedChanging(System.DateTime value);
    partial void OnDateModifiedChanged();
    partial void OnFavoriteCountChanging(int value);
    partial void OnFavoriteCountChanged();
    partial void OnLikeCountChanging(int value);
    partial void OnLikeCountChanged();
    #endregion
		
		public Recipe()
		{
			this._Ingredients = new EntitySet<Ingredient>(new Action<Ingredient>(this.attach_Ingredients), new Action<Ingredient>(this.detach_Ingredients));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RecipeID
		{
			get
			{
				return this._RecipeID;
			}
			set
			{
				if ((this._RecipeID != value))
				{
					this.OnRecipeIDChanging(value);
					this.SendPropertyChanging();
					this._RecipeID = value;
					this.SendPropertyChanged("RecipeID");
					this.OnRecipeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Instructions", DbType="NVarChar(4000) NOT NULL", CanBeNull=false)]
		public string Instructions
		{
			get
			{
				return this._Instructions;
			}
			set
			{
				if ((this._Instructions != value))
				{
					this.OnInstructionsChanging(value);
					this.SendPropertyChanging();
					this._Instructions = value;
					this.SendPropertyChanged("Instructions");
					this.OnInstructionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime NOT NULL")]
		public System.DateTime DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateModified", DbType="DateTime NOT NULL")]
		public System.DateTime DateModified
		{
			get
			{
				return this._DateModified;
			}
			set
			{
				if ((this._DateModified != value))
				{
					this.OnDateModifiedChanging(value);
					this.SendPropertyChanging();
					this._DateModified = value;
					this.SendPropertyChanged("DateModified");
					this.OnDateModifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FavoriteCount", DbType="Int NOT NULL")]
		public int FavoriteCount
		{
			get
			{
				return this._FavoriteCount;
			}
			set
			{
				if ((this._FavoriteCount != value))
				{
					this.OnFavoriteCountChanging(value);
					this.SendPropertyChanging();
					this._FavoriteCount = value;
					this.SendPropertyChanged("FavoriteCount");
					this.OnFavoriteCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LikeCount", DbType="Int NOT NULL")]
		public int LikeCount
		{
			get
			{
				return this._LikeCount;
			}
			set
			{
				if ((this._LikeCount != value))
				{
					this.OnLikeCountChanging(value);
					this.SendPropertyChanging();
					this._LikeCount = value;
					this.SendPropertyChanged("LikeCount");
					this.OnLikeCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Recipe_Ingredient", Storage="_Ingredients", ThisKey="RecipeID", OtherKey="RecipeId")]
		public EntitySet<Ingredient> Ingredients
		{
			get
			{
				return this._Ingredients;
			}
			set
			{
				this._Ingredients.Assign(value);
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
		
		private void attach_Ingredients(Ingredient entity)
		{
			this.SendPropertyChanging();
			entity.Recipe = this;
		}
		
		private void detach_Ingredients(Ingredient entity)
		{
			this.SendPropertyChanging();
			entity.Recipe = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Recipe_Comment")]
	public partial class Recipe_Comment
	{
		
		private int _RecipeId;
		
		private int _CommentId;
		
		public Recipe_Comment()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipeId", DbType="Int NOT NULL")]
		public int RecipeId
		{
			get
			{
				return this._RecipeId;
			}
			set
			{
				if ((this._RecipeId != value))
				{
					this._RecipeId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentId", DbType="Int NOT NULL")]
		public int CommentId
		{
			get
			{
				return this._CommentId;
			}
			set
			{
				if ((this._CommentId != value))
				{
					this._CommentId = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Recipe_Favoriter")]
	public partial class Recipe_Favoriter
	{
		
		private int _RecipeId;
		
		private int _UserId;
		
		public Recipe_Favoriter()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipeId", DbType="Int NOT NULL")]
		public int RecipeId
		{
			get
			{
				return this._RecipeId;
			}
			set
			{
				if ((this._RecipeId != value))
				{
					this._RecipeId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this._UserId = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Recipe_Image")]
	public partial class Recipe_Image
	{
		
		private int _RecipeId;
		
		private int _ImageId;
		
		public Recipe_Image()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipeId", DbType="Int NOT NULL")]
		public int RecipeId
		{
			get
			{
				return this._RecipeId;
			}
			set
			{
				if ((this._RecipeId != value))
				{
					this._RecipeId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageId", DbType="Int NOT NULL")]
		public int ImageId
		{
			get
			{
				return this._ImageId;
			}
			set
			{
				if ((this._ImageId != value))
				{
					this._ImageId = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Recipe_Liker")]
	public partial class Recipe_Liker
	{
		
		private int _RecipeId;
		
		private int _UserId;
		
		public Recipe_Liker()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipeId", DbType="Int NOT NULL")]
		public int RecipeId
		{
			get
			{
				return this._RecipeId;
			}
			set
			{
				if ((this._RecipeId != value))
				{
					this._RecipeId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this._UserId = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Recipe_Tag")]
	public partial class Recipe_Tag
	{
		
		private int _RecipeID;
		
		private string _Tag;
		
		public Recipe_Tag()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipeID", DbType="Int NOT NULL")]
		public int RecipeID
		{
			get
			{
				return this._RecipeID;
			}
			set
			{
				if ((this._RecipeID != value))
				{
					this._RecipeID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tag", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Tag
		{
			get
			{
				return this._Tag;
			}
			set
			{
				if ((this._Tag != value))
				{
					this._Tag = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
