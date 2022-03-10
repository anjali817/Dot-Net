<h1>===========ViewBag=========</h1>
<h1>@ViewBag.abc</h1>
<h1>@ViewBag.test</h1>
<h1>@ViewBag.test1</h1>
<h1>@ViewBag.test2</h1>

<ul>
    @foreach (var item in ViewBag.list)
    {
        <li>@item</li>
    }
</ul>

<h1>=========ViewData=========</h1>
<h1>@ViewData["abc"]</h1>
<h1>@ViewData["test"]</h1>
<h1>@ViewData["test1"]</h1>
<h1>@ViewData["test2"]</h1>
<h1>@ViewData["test3"]</h1>
<ul>
    @foreach (var item in (List<string>)(ViewData["ListData"]))
    {
        <li>@item</li>
    }
</ul>