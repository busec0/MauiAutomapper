using MauiAutomapper.Models;

namespace MauiAutomapper;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();

        DtoMapper.Initialize();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        var parent = new Parent()
        {
            Name = "Andrew",
            Children = new List<Child>()
            {
                new Child() {Age = 12 },
                new Child() {Age = 12 },
            }
        };

        var parent2 = new Parent()
        {
            Name = "John",
            Children = new List<Child>()
            {
                new Child() {Age = 9 },
                new Child() {Age = 3 },
            }
        };

        var children = new List<Child>()
        {
            new Child() {Age = 9 },
            new Child() {Age = 3 },
        };

        //works fine on both iOS and Android
        var result = DtoMapper.Map<List<ChildDto>>(children);
        System.Diagnostics.Debug.WriteLine(result);

        //fails on iOS. Cannot map the Children property.
        //NOTE: ANDROID WORKS FINE!
        var result1 = DtoMapper.Map<ParentDto>(parent);
        System.Diagnostics.Debug.WriteLine(result1);

        var parents = new List<Parent> { parent, parent2 };
        var result2 = DtoMapper.Map<List<ParentDto>>(parents);
        System.Diagnostics.Debug.WriteLine(result2);
    }
}


