double CirkelArea(double r){
    return(r*r*3.1415);
}
double CirkelOmkrets(double r){
    return((r+r)*3.1415);
}

double radie=2.4;
Console.WriteLine("Cirkelns omkrets: "+CirkelOmkrets(radie));
Console.WriteLine("Cirkelns area: "+CirkelArea(radie));


double Average(double a, double b, double c){
    return((a+b+c)/3);
}

double a = 5.2, b = 3.4, c = 1.5;
Console.WriteLine("medelvärdet är " + Average(a,b,c));