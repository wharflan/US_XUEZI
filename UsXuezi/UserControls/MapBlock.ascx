<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MapBlock.ascx.cs" Inherits="UsXuezi.UserControls.MapBlock" %>
<script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=true"></script>
<script type="text/javascript" src="/Script/gmaps.js"></script>

<div id="googlemapblock"></div>
<style>
    #googlemapblock {
        background-color: ActiveCaption;
        display: block;
        min-height:200px; 
        min-width:360px;  
        width: <%=Width %>;
        height: <%=Height %>;
    }
</style>



