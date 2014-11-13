<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EstateFilter.ascx.cs" Inherits="UsXuezi.UserControls.Filters.EstateFilter" %>
<div class="filter_content filter-box ep-filter" style="padding: 0px">
    <div class="filter_item">
        <dl class="filter-region">
            <dt>地区：</dt>
            <dd>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Boston</span></label>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Cambridge</span></label>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Quincy</span></label>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Waltham</span></label>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Newton</span></label>
            </dd>
        </dl>
        <dl class="filter-type">
            <dt>地产类型：</dt>
            <dd>
                <label class="m-cb"><input type="checkbox" name="filter-type"><span>Condos</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-type"><span>Apartments</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-type"><span>Houses</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-type"><span>Comercial</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-type"><span>Land</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-type"><span>Others</span></label>
            </dd>
        </dl>
        <dl class="filter-roomNum">
            <dt>卧室数量：</dt>
            <dd>
                <label class="m-cb"><input type="checkbox" name="filter-roomNum"><span>1</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-roomNum"><span>2</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-roomNum"><span>3</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-roomNum"><span>4</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-roomNum"><span>5+</span></label>
            </dd>
        </dl>
        <span class="divide"></span>
        <dl class="filter-bathroomNum">
            <dt>卫浴数量：</dt>
            <dd>
                <label class="m-cb"><input type="checkbox" name="filter-bathroomNum"><span>1</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-bathroomNum"><span>2</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-bathroomNum"><span>3</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-bathroomNum"><span>4+</span></label>
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