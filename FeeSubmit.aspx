<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FeeSubmit.aspx.cs" Inherits="FeeSubmit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="page-wrapper">
            <div class="content">
                <div class="row">
                    <div class="col-sm-12">
                        <h4 class="page-title">Fees Submit</h4>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="card-box">
                            <h4 class="card-title">Fill Here</h4>
                  
    <asp:HiddenField ID="hdfcField" runat="server" />
                                <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Application No:</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtapplicationno" runat="server" CssClass="form-control"  AutoPostBack="True" ontextchanged="txtapplicationno_TextChanged"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Name of the Candidate:</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtname" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Father /Guardian Name:</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtfathername" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Total Fee</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txttotalamt" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Received Amt</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtreceivedamt" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Balance Amt</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtbalanceamt" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">   
                                    <label class="col-md-3 col-form-label">Amount To Be Paid</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtamount" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Installment No</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtinstallment" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Payment Mode</label>
                                    <div class="col-md-9">
                                  <asp:DropDownList ID="ddlpaymentmode" runat="server" CssClass="form-control">
                                  <asp:ListItem>Cash</asp:ListItem>
                                  <asp:ListItem>Online</asp:ListItem>
                                  <asp:ListItem>Cheque</asp:ListItem>
                                
                                </asp:DropDownList>
                                    </div>
                                </div>
                               
                                  <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Remark</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtremarks" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                
                                
                              
                                <div class="text-right">
                                <asp:Button ID="Button1" runat="server" Text="Submit" class="btn btn-primary" 
                                        onclick="Button1_Click" />
                                 
                                </div>
                    
                        </div>
                    </div>
                    
                </div>
               
            </div>
         
        </div>
</asp:Content>

