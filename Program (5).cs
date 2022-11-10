for (double x = -2; x <= 1; x += 0.5) {
    double result = 0;
    if (x > 0) {
        for (var k = 3; k <= 9; k++) result += Math.Pow(x, -k);
    } else {
        result = Math.Pow(2 - x, 2 - x);
    }
    Console.WriteLine($"x = {x}, f(x) = {result}");    
}