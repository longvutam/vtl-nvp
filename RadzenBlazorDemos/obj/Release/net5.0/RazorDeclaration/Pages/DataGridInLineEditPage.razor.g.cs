// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RadzenBlazorDemos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\_Imports.razor"
using RadzenBlazorDemos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridInLineEditPage.razor"
using RadzenBlazorDemos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridInLineEditPage.razor"
using RadzenBlazorDemos.Models.Northwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridInLineEditPage.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-inline-edit")]
    public partial class DataGridInLineEditPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "C:\Users\owlsn\source\repos\vtl-nvp\RadzenBlazorDemos\Pages\DataGridInLineEditPage.razor"
       
    RadzenDataGrid<Order> ordersGrid;
    IList<Order> orders;
    IEnumerable<Customer> customers;
    IEnumerable<Employee> employees;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        customers = dbContext.Customers.ToList();
        employees = dbContext.Employees.ToList();

        // For demo purposes only
        orders = dbContext.Orders.Include("Customer").Include("Employee").ToList();

        // For production
        //orders = dbContext.Orders.Include("Customer").Include("Employee");
    }

    void EditRow(Order order)
    {
        ordersGrid.EditRow(order);
    }

    void OnUpdateRow(Order order)
    {
        dbContext.Update(order);

        // For demo purposes only
        order.Customer = dbContext.Customers.Find(order.CustomerID);
        order.Employee = dbContext.Employees.Find(order.EmployeeID);

        // For production
        //dbContext.SaveChanges();
    }

    void SaveRow(Order order)
    {
        ordersGrid.UpdateRow(order);
    }

    void CancelEdit(Order order)
    {
        ordersGrid.CancelEditRow(order);

        // For production
        var orderEntry = dbContext.Entry(order);
        if (orderEntry.State == EntityState.Modified)
        {
            orderEntry.CurrentValues.SetValues(orderEntry.OriginalValues);
            orderEntry.State = EntityState.Unchanged;
        }
    }

    void DeleteRow(Order order)
    {
        if (orders.Contains(order))
        {
            dbContext.Remove<Order>(order);

            // For demo purposes only
            orders.Remove(order);

            // For production
            //dbContext.SaveChanges();

            ordersGrid.Reload();
        }
        else
        {
            ordersGrid.CancelEditRow(order);
        }
    }

    void InsertRow()
    {
        ordersGrid.InsertRow(new Order());
    }

    void OnCreateRow(Order order)
    {
        dbContext.Add(order);

        // For demo purposes only
        order.Customer = dbContext.Customers.Find(order.CustomerID);
        order.Employee = dbContext.Employees.Find(order.EmployeeID);

        // For production
        //dbContext.SaveChanges();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindContext dbContext { get; set; }
    }
}
#pragma warning restore 1591
