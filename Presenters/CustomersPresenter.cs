﻿using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class CustomersPresenter
    {
        private ICustomersView view;
        private ICustomersRepository repository;
        private BindingSource customersBindingSource;
        private IEnumerable<CustomersModel> customersList;

        public CustomersPresenter(ICustomersView view, ICustomersRepository repository)
        {
            this.customersBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomers;
            this.view.AddNewEvent += AddNewCustomers;
            this.view.EditEvent += LoadSelectCustomersToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomers;
            this.view.SaveEvent += SaveCustomers;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomersListBildingSource(customersBindingSource);

            LoadAllCustomersList();

            this.view.Show();

        }

        private void LoadAllCustomersList()
        {
            customersList = repository.GetAll();
            customersBindingSource.DataSource = customersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCustomers(object? sender, EventArgs e)
        {
            var customers = new CustomersModel();
            customers.Id = Convert.ToInt32(view.CustomersId);
            customers.Document = view.CustomersDocNum;
            customers.FirstName = view.CustomersFirstName;
            customers.LastName = view.CustomersLastName;
            customers.Address = view.CustomersAddress;
            customers.Birthday = view.CustomersBirthday;
            customers.PhoneNumber = view.CustomersPhoneNumber;
            customers.Email = view.CustomersEmail;

            try
            {
                new Common.ModelDataValidation().Validate(customers);
                if (view.IsEdit)
                {
                    repository.Edit(customers);
                    view.Message = "Customers Edit Successfully";
                }
                else
                {
                    repository.Add(customers);
                    view.Message = "Customers added Successfully";
                }
                view.IsSuccessful = true;
                LoadAllCustomersList();
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
            view.CustomersId = "0";
            view.CustomersDocNum = "";
            view.CustomersFirstName = "";
            view.CustomersLastName = "";
            view.CustomersAddress = "";
            view.CustomersBirthday = "";
            view.CustomersPhoneNumber = "";
            view.CustomersEmail = "";
        }

        private void DeleteSelectedCustomers(object? sender, EventArgs e)
        {
            try
            {
                var customers = (CustomersModel)customersBindingSource.Current;
                repository.Delete(customers.Id);
                view.IsSuccessful = true;
                view.Message = "Customers deleted Successfully";
                LoadAllCustomersList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete Customers";
            }
        }

        private void LoadSelectCustomersToEdit(object? sender, EventArgs e)
        {
            var customers = (CustomersModel)customersBindingSource.Current;

            view.CustomersId = customers.Id.ToString();
            /*view.CustomersName = customers.Name;
            view.CustomersDescription = customers.Description;*/
            
            view.CustomersDocNum = customers.Document;
            view.CustomersFirstName = customers.FirstName;
            view.CustomersLastName = customers.LastName;
            view.CustomersAddress = customers.Address;
            view.CustomersBirthday = customers.Birthday;
            view.CustomersPhoneNumber = customers.PhoneNumber;
            view.CustomersEmail = customers.Email;

            view.IsEdit = true;
        }

        private void AddNewCustomers(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCustomers(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                customersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customersList = repository.GetAll();
            }
            customersBindingSource.DataSource = customersList;
        }

    }
}

