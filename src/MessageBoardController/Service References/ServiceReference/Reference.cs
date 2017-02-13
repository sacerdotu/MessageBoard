﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessageBoardController.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertNewUser", ReplyAction="http://tempuri.org/IService1/InsertNewUserResponse")]
        void InsertNewUser(MessageBoardDTO.UserDTO user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertNewUser", ReplyAction="http://tempuri.org/IService1/InsertNewUserResponse")]
        System.Threading.Tasks.Task InsertNewUserAsync(MessageBoardDTO.UserDTO user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckUserAndPassword", ReplyAction="http://tempuri.org/IService1/CheckUserAndPasswordResponse")]
        MessageBoardDTO.UserDTO CheckUserAndPassword(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckUserAndPassword", ReplyAction="http://tempuri.org/IService1/CheckUserAndPasswordResponse")]
        System.Threading.Tasks.Task<MessageBoardDTO.UserDTO> CheckUserAndPasswordAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FillUsersGrid", ReplyAction="http://tempuri.org/IService1/FillUsersGridResponse")]
        MessageBoardDTO.UserDTO[] FillUsersGrid();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FillUsersGrid", ReplyAction="http://tempuri.org/IService1/FillUsersGridResponse")]
        System.Threading.Tasks.Task<MessageBoardDTO.UserDTO[]> FillUsersGridAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserDetails", ReplyAction="http://tempuri.org/IService1/GetUserDetailsResponse")]
        MessageBoardDTO.UserDTO GetUserDetails(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserDetails", ReplyAction="http://tempuri.org/IService1/GetUserDetailsResponse")]
        System.Threading.Tasks.Task<MessageBoardDTO.UserDTO> GetUserDetailsAsync(int userID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MessageBoardController.ServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MessageBoardController.ServiceReference.IService1>, MessageBoardController.ServiceReference.IService1 {
        
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
        
        public void InsertNewUser(MessageBoardDTO.UserDTO user) {
            base.Channel.InsertNewUser(user);
        }
        
        public System.Threading.Tasks.Task InsertNewUserAsync(MessageBoardDTO.UserDTO user) {
            return base.Channel.InsertNewUserAsync(user);
        }
        
        public MessageBoardDTO.UserDTO CheckUserAndPassword(string username) {
            return base.Channel.CheckUserAndPassword(username);
        }
        
        public System.Threading.Tasks.Task<MessageBoardDTO.UserDTO> CheckUserAndPasswordAsync(string username) {
            return base.Channel.CheckUserAndPasswordAsync(username);
        }
        
        public MessageBoardDTO.UserDTO[] FillUsersGrid() {
            return base.Channel.FillUsersGrid();
        }
        
        public System.Threading.Tasks.Task<MessageBoardDTO.UserDTO[]> FillUsersGridAsync() {
            return base.Channel.FillUsersGridAsync();
        }
        
        public MessageBoardDTO.UserDTO GetUserDetails(int userID) {
            return base.Channel.GetUserDetails(userID);
        }
        
        public System.Threading.Tasks.Task<MessageBoardDTO.UserDTO> GetUserDetailsAsync(int userID) {
            return base.Channel.GetUserDetailsAsync(userID);
        }
    }
}
