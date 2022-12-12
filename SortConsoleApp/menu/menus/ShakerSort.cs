namespace SortConsoleApp.menu.menus;

public class ShakerSort : AlgorithmStringSortMenu
{
    public ShakerSort(bool isSelected = false) : base(sort: new algorithms.ShakerSort(),
        title: "Shaker Сортировка текста", isSelected) { }
}