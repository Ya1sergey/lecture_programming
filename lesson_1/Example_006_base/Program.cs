﻿int a = 1;
int b = 8;
int c = 12;
int d = 12;
int e = 6;

int max = a;

if(max < b) max = b;
if(max < c) max = c;
if(max < d) max = d;
if(max < e) max = e;

Console.Write("max = ");
Console.WriteLine(max);