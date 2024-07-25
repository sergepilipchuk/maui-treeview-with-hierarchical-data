using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TreeView.Data;

public static class ReportLibraryData {
    public static ReportLibraryNode Generate() {
        var root = new ReportLibraryNode();
        var orders = new ReportLibraryNode() { Name = "Orders" };
        var customers = new ReportLibraryNode() { Name = "Customers" };
        var employees = new ReportLibraryNode() { Name = "Employees" };
        var marketResearch = new ReportLibraryNode() { Name = "Market Research" };
        var barCodes = new ReportLibraryNode() { Name = "Bar Codes" };
        var crossBand = new ReportLibraryNode() { Name = "Cross Band" };
        var realLife = new ReportLibraryNode() { Name = "Real-Life" };
        var products = new ReportLibraryNode() { Name = "Products" };
        var sales = new ReportLibraryNode() { Name = "Sales" };
        var northwindTraders = new ReportLibraryNode() { Name = "Northwind Traders" };

        orders.AddNode(new ReportLibraryNode() { Name = "Detail.pdf" });
        orders.AddNode(new ReportLibraryNode() { Name = "Summary.pdf" });
        
        customers.AddNode(orders);
        customers.AddNode(new ReportLibraryNode() { Name = "Balance sheet.pdf" });
        customers.AddNode(new ReportLibraryNode() { Name = "Revenue by company.pdf" });

        employees.AddNode(new ReportLibraryNode() { Name = "Arrival card.pdf" });
        employees.AddNode(new ReportLibraryNode() { Name = "Employee comparison.pdf" });
        employees.AddNode(new ReportLibraryNode() { Name = "Employee location.pdf" });
        employees.AddNode(new ReportLibraryNode() { Name = "Employee performance review.pdf" });
        employees.AddNode(new ReportLibraryNode() { Name = "Letter.pdf" });

        marketResearch.AddNode(new ReportLibraryNode() { Name = "Market share.pdf" });
        marketResearch.AddNode(new ReportLibraryNode() { Name = "Polling.pdf" });
        marketResearch.AddNode(new ReportLibraryNode() { Name = "Population.pdf" });
        marketResearch.AddNode(new ReportLibraryNode() { Name = "Profit and loss.pdf" });

        barCodes.AddNode(new ReportLibraryNode() { Name = "All product labels.pdf" });
        barCodes.AddNode(new ReportLibraryNode() { Name = "Code types.pdf" });
        barCodes.AddNode(new ReportLibraryNode() { Name = "Product label.pdf" });

        crossBand.AddNode(new ReportLibraryNode() { Name = "Invoice.pdf" });
        crossBand.AddNode(new ReportLibraryNode() { Name = "Product list.pdf" });

        realLife.AddNode(new ReportLibraryNode() { Name = "Restaurant menu.pdf" });
        realLife.AddNode(new ReportLibraryNode() { Name = "Roll paper.pdf" });

        products.AddNode(barCodes);
        products.AddNode(crossBand);
        products.AddNode(realLife);
        products.AddNode(new ReportLibraryNode() { Name = "Sorting products.pdf" });

        northwindTraders.AddNode(new ReportLibraryNode() { Name = "Catalog.pdf" });
        northwindTraders.AddNode(new ReportLibraryNode() { Name = "Invoice.pdf" });
        northwindTraders.AddNode(new ReportLibraryNode() { Name = "Product list.pdf" });

        sales.AddNode(northwindTraders);
        sales.AddNode(new ReportLibraryNode() { Name = "ACME order overview.pdf" });
        sales.AddNode(new ReportLibraryNode() { Name = "Multi-table order list.pdf" });
        sales.AddNode(new ReportLibraryNode() { Name = "Order details.pdf" });
        sales.AddNode(new ReportLibraryNode() { Name = "Single-table order list.pdf" });
        sales.AddNode(new ReportLibraryNode() { Name = "Summary by year.pdf" });

        root.AddNode(customers);
        root.AddNode(employees);
        root.AddNode(marketResearch);
        root.AddNode(products);
        root.AddNode(sales);

        return root;
    }
}

public class ReportLibraryNode {
    public string Name { get; set; }

    public ObservableCollection<ReportLibraryNode> Nodes { get; }

    public ReportLibraryNode() {
        Nodes = new();
    }
    
    public void AddNode(ReportLibraryNode node) {
        Nodes.Add(node);
    }
}
