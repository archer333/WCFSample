﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProducts", ReplyAction="http://tempuri.org/IService1/GetProductsResponse")]
        System.Collections.ObjectModel.ObservableCollection<Models.Product> GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProducts", ReplyAction="http://tempuri.org/IService1/GetProductsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Models.Product>> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomers", ReplyAction="http://tempuri.org/IService1/GetCustomersResponse")]
        System.Collections.ObjectModel.ObservableCollection<Models.Customer> GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomers", ReplyAction="http://tempuri.org/IService1/GetCustomersResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Models.Customer>> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrders", ReplyAction="http://tempuri.org/IService1/GetOrdersResponse")]
        System.Collections.ObjectModel.ObservableCollection<Models.Order> GetOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrders", ReplyAction="http://tempuri.org/IService1/GetOrdersResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Models.Order>> GetOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrderItems", ReplyAction="http://tempuri.org/IService1/GetOrderItemsResponse")]
        System.Collections.ObjectModel.ObservableCollection<Models.OrderItem> GetOrderItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrderItems", ReplyAction="http://tempuri.org/IService1/GetOrderItemsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Models.OrderItem>> GetOrderItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SubmitOrder", ReplyAction="http://tempuri.org/IService1/SubmitOrderResponse")]
        void SubmitOrder(Models.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SubmitOrder", ReplyAction="http://tempuri.org/IService1/SubmitOrderResponse")]
        System.Threading.Tasks.Task SubmitOrderAsync(Models.Order order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference1.IService1>, Client.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.ObjectModel.ObservableCollection<Models.Product> GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Models.Product>> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public System.Collections.ObjectModel.ObservableCollection<Models.Customer> GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Models.Customer>> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public System.Collections.ObjectModel.ObservableCollection<Models.Order> GetOrders() {
            return base.Channel.GetOrders();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Models.Order>> GetOrdersAsync() {
            return base.Channel.GetOrdersAsync();
        }
        
        public System.Collections.ObjectModel.ObservableCollection<Models.OrderItem> GetOrderItems() {
            return base.Channel.GetOrderItems();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<Models.OrderItem>> GetOrderItemsAsync() {
            return base.Channel.GetOrderItemsAsync();
        }
        
        public void SubmitOrder(Models.Order order) {
            base.Channel.SubmitOrder(order);
        }
        
        public System.Threading.Tasks.Task SubmitOrderAsync(Models.Order order) {
            return base.Channel.SubmitOrderAsync(order);
        }
    }
}
