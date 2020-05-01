# ProgressTask-Blazor

Inside BlazorComponents library I have created the Menu component with all its dependencies.
To use that component all we have to do is pass it some parameters:
  - list of objects that extends IMenuItem interface
  - callback methot to be executed when an item is clicked
 
By extending the IMenuItem we can include any business data that can be retrived latter inside the callback method.
You can check the example in BlazorDemo project inside the Index.razor file.
