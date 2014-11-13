<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UsedCarFilter.ascx.cs" Inherits="UsXuezi.UserControls.Filters.UsedCarFilter" %>
<div class="filter_content filter-box uc-filter" style="padding: 0px">
    <div class="filter_item">
        <dl class="filter-years">
            <dt>年份：</dt>
            <dd>
                <label class="m-cb"><input type="checkbox" name="filter-years"><span>≤2005</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-years"><span>2005 - 2009</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-years"><span>2010 - 2013</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-years"><span>2014+</span></label>
            </dd>
        </dl>
        <dl class="filter-mileage">
            <dt>里程：</dt>
            <dd>
                <label class="m-cb"><input type="checkbox" name="filter-mileage"><span>≤5k miles</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-mileage"><span>5k - 10k miles</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-mileage"><span>10k - 30k miles</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-mileage"><span>30k - 50k miles</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-mileage"><span>50k miles +</span></label>
            </dd>
        </dl>
        <dl class="filter-type">
            <dt>Dealer车源：</dt>
            <dd>
                <label class="m-ra"><input type="radio" name="filter-type"><span>是</span></label>
                <label class="m-ra"><input type="radio" name="filter-type"><span>否</span></label>
                <label class="m-ra"><input type="radio" name="filter-type"><span>不限</span></label>
            </dd>
        </dl>
    </div>
    <div class="m-sort">
        <dl>
            <dt>排序方式：</dt>
            <dd>
                <label class="m-ra"><input type="radio" name="sortord"><span>最新发布</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord"><span>最低价格</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord"><span>最高价格</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord" checked=""><span>默认排序</span></label>
            </dd>
        </dl>
    </div>
</div>