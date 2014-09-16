<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FoodFilter.ascx.cs" Inherits="UsXuezi.UserControls.Filters.FoodFilter" %>
<div class="filter_content filter-box food-filter" style="padding: 0px">
    <div class="m-sort">
        <dl>
            <dt>排序方式：</dt>
            <dd>
                <label class="m-ra"><input type="radio" name="sortord"><span>最新发布</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord"><span>最高评价</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord"><span>提供优惠</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord" checked=""><span>默认排序</span></label>
            </dd>
        </dl>
    </div>
</div>