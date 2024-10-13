using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class CategoriPresenter
    {
        private ICategoriesView view;
        private ICategoriRepository repository;
        private BindingSource categoriBindingSource;
        private IEnumerable<CategoriModel> categorieList;

        public CategoriPresenter(ICategoriesView view, ICategoriRepository repository)
        {
            this.categoriBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategori;
            this.view.AddNewEvent += AddNewCategori;
            this.view.EditEvent += LoadSelectCategorieToEdit;
            this.view.DeleteEvent += DeleteSelectedCategorie;
            this.view.SaveEvent += SaveCategori;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoriListBildingSource(categoriBindingSource);

            LoadAllCategoriList();

            this.view.Show();

        }

        private void LoadAllCategoriList()
        {
            categorieList = repository.GetAll();
            categoriBindingSource.DataSource = categorieList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCategori(object? sender, EventArgs e)
        {
            var categori = new CategoriModel();
            categori.Id = Convert.ToInt32(view.CategoriId);
            categori.Name = view.CategoriName;
            categori.Description = view.CategoriDescription;

            try
            {
                new Common.ModelDataValidation().Validate(categori);
                if (view.IsEdit)
                {
                    repository.Edit(categori);
                    view.Message = "PayMode Edit Successfuly";
                }
                else
                {
                    repository.Add(categori);
                    view.Message = "PayMode added Successfuly";
                }
                view.IsSuccessful = true;
                LoadAllCategoriList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

        }

        private void CleanViewFields()
        {
            view.CategoriId = "0";
            view.CategoriName = "";
            view.CategoriDescription = "";
        }

        private void DeleteSelectedCategorie(object? sender, EventArgs e)
        {
            try
            {
                var Categorie = (CategoriModel)categoriBindingSource.Current;
                repository.Delete(Categorie.Id);
                view.IsSuccessful = true;
                view.Message = "Categori deleted Successfuly";
                LoadAllCategoriList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete Categorie";
            }
        }

        private void LoadSelectCategorieToEdit(object? sender, EventArgs e)
        {
            var categori = (CategoriModel)categoriBindingSource.Current;

            view.CategoriId = categori.Id.ToString();
            view.CategoriName = categori.Name;
            view.CategoriDescription = categori.Description;

            view.IsEdit = true;
        }

        private void AddNewCategori(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategori(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categorieList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categorieList = repository.GetAll();
            }
            categoriBindingSource.DataSource = categorieList;
        }
    }
}
