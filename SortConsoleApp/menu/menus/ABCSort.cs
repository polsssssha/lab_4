namespace SortConsoleApp.menu.menus
{
    public class ABCSort : AlgorithmStringSortMenu
    {
        public ABCSort(bool isSelected = false) : base(sort: new algorithms.ABCSort(), title: "ABC Сортировка текста",
            isSelected) { }
    }
}