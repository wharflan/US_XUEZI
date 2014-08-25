﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Signature.ascx.cs" Inherits="UsXuezi.UserControls.Signature" %>

<!-- include CSS always before including js -->
<link type="text/css" rel="stylesheet" href="/Script/TN3/skins/tn3/tn3.css"></link>
<!-- include jQuery library -->

<!-- include tn3 plugin -->
<script type="text/javascript" src="/Script/TN3/js/jquery.tn3lite.min.js"></script>

<!--  initialize the TN3 when the DOM is ready -->
<script type="text/javascript">
    $(document).ready(function () {
        //Thumbnailer.config.shaderOpacity = 1;
        var tn1 = $('.mygallery').tn3({
            skinDir: "skins",
            imageClick: "fullscreen",
            image: {
                maxZoom: 1.5,
                crop: true,
                clickEvent: "dblclick",
                transitions: [{
                    type: "blinds"
                }, {
                    type: "grid"
                }, {
                    type: "grid",
                    duration: 460,
                    easing: "easeInQuad",
                    gridX: 1,
                    gridY: 8,
                    // flat, diagonal, circle, random
                    sort: "random",
                    sortReverse: false,
                    diagonalStart: "bl",
                    // fade, scale
                    method: "scale",
                    partDuration: 360,
                    partEasing: "easeOutSine",
                    partDirection: "left"
                }]
            }
        });
    });
</script>
<div id="content" class="pictures" runat="server">
    <div class="mygallery">
        <div class="tn3 album">
            <h4>Fixed Dimensions</h4>
            <div class="tn3 description">Images with fixed dimensions</div>
            <div class="tn3 thumb">images/35x35/1.jpg</div>
            <ol>
                <%foreach (Maticsoft.Model.Tb_Signature temp in Mls)
                  {
                %>
                <li>
                    <h4><%=temp.Signature_Name %></h4>
                    <div class="tn3 description"><%=temp.Signature_Description %></div>
                    <a href="<%=temp.Signature_Img %>">
                        <img src="<%=temp.Signature_Img %>" />
                    </a>
                </li>
                <%
                  } %>
            </ol>
        </div>
    </div>
</div>
