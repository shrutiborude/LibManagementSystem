using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibManagementSystem_Updated
{
    public abstract class BaseEntityForm<T> : Form where T : class, new()
    {
        protected readonly DatabaseService<T> _service;
        protected T selectedEntity;

        protected BaseEntityForm()
        {
            _service = new DatabaseService<T>();
        }

        // Abstract method for form validation (implemented in derived forms)
        protected abstract bool ValidateForm();
        protected abstract void PopulateEntity(T entity);
        protected abstract void LoadData(DataGridView dataGridView);
        protected abstract void ClearForm();

        protected virtual void SaveEntity()
        {
            if (!ValidateForm())  // Common Validation
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var entity = selectedEntity ?? new T();  // New entity if none selected
            PopulateEntity(entity);  // Populate entity with form data

            //_service.SaveOrUpdate(entity);  // Add or Update automatically
            MessageBox.Show("Saved successfully!");

            LoadData(GetDataGridView());  // Refresh DataGridView
            ClearForm();
        }

        protected virtual void DeleteEntity()
        {
            if (selectedEntity == null)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            _service.Delete(selectedEntity);
            MessageBox.Show("Deleted successfully!");

            LoadData(GetDataGridView());
            ClearForm();
        }

        protected abstract DataGridView GetDataGridView();  // Get DataGridView reference
    }
}
