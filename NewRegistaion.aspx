<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NewRegistaion.aspx.cs" Inherits="NewRegistaion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="page-wrapper">
            <div class="content">
                <div class="row">
                    <div class="col-sm-12">
                        <h4 class="page-title">New Registaion</h4>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="card-box">
                            <h4 class="card-title">Fill Form</h4>
                  
                                <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Application No:</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtapplicationno" runat="server" CssClass="form-control"></asp:TextBox>
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
                                    <label class="col-md-3 col-form-label">Date of Birth:</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtdob" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Gender:</label>
                                    <div class="col-md-9">
                                        <asp:DropDownList ID="ddlgender" runat="server" CssClass="form-control">
                                        <asp:ListItem>Male</asp:ListItem><asp:ListItem>Female</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Full Address:</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtaddress" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">State</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtstate" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">City</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtcity" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Pincode</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtpincode" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Mobile No</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtmobileno" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Email Id</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtemailid" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Father’s Occupation</label>
                                    <div class="col-md-9">
                                        <asp:DropDownList ID="ddloccupation" runat="server" CssClass="form-control">
                                         <asp:ListItem>Employed</asp:ListItem>
                                         <asp:ListItem>Self-Employed</asp:ListItem>
                                         <asp:ListItem>Retired</asp:ListItem>
                                         <asp:ListItem>Others</asp:ListItem> 
                                        </asp:DropDownList>
                                    </div>
                                </div>
                               <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Course</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txtcourse" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Total Fee</label>
                                    <div class="col-md-9">
                                    <asp:TextBox ID="txttotalfee" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group row">
                                    <label class="col-md-3 col-form-label">Upload Picture</label>
                                    <div class="col-md-9">
                                        <asp:FileUpload ID="FileUpload1" runat="server"  CssClass="form-control"/>
                                    </div>
                                </div>
                                
                              
                                <div class="text-right">
                                <asp:Button ID="Button1" runat="server" Text="Submit" class="btn btn-primary" 
                                        onclick="Button1_Click" />
                                    <%--<button type="submit" class="btn btn-primary">Submit</button>--%>
                                </div>
                    
                        </div>
                    </div>
                    
                </div>
               
            </div>
         
        </div>
</asp:Content>

