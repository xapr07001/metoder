double CirkelArea(double r){
    return(r*r*3.1415);
}
double CirkelOmkrets(double r){
    return((r+r)*3.1415);
}

double Average(double a, double b, double c){
    return((a+b+c)/3);
}

Console.WriteLine("Cirkelns omkrets: "+CirkelOmkrets(2.4));
Console.WriteLine("Cirkelns area: "+CirkelArea(2.4));
Console.WriteLine("medelvärdet är " + Average(5.2,3.4,1.5));