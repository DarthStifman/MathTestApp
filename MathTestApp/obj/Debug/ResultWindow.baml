   M S B A M L   `   `   `  ����F  BMathTestApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MathTestAppMathTestApp  5   	       MathTestApp.ResultWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MathTestApp     5   	     � Title$  ResultWindow��5   	   $	��200��6   $	��270��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��1��6   $��0��6%    �� Orientation$ 
Horizontal=�62   .+�5      �� $��25(�6   $��	-10,0,0,0q�6"   $��DemiBold"�65   .��5      �� $��	Underline{�6   Result6@   5      5      �� 5   
   $��0��6   $��1��6%   $ Vertical=�62   .+�5      �� $��2q�6   .��6   Your answer:6-   �� 5      $��2q�6   .��6   Correct Answer:60   �� 5      $��2q�6   .��6   Time:6&   5       �� 5"   
   $��1��6   $��1��6%   $ Vertical=�62   .+�5#      �� -   5        $��LbAnswer��5#      $��2q�6$   .��6/   Correct/Wrong6>   �� 5$      -   5        $��LbCorrectResult��5$      $��2q�6+   .��66   Correct result6F   �� 5%      -   5        $��LbTime��5%      $��2q�6"   .��6-   Question time6<   5&      �� 5(   
   $��1��6   $��2��6%   $ 
Horizontal=�62   .+�5)      �� -   5        $��20��5)      $��70��6!   $��-5,5,0,0q�6,   .��6S   Ok6W   5*      5+      5,      