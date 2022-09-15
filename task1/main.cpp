#include <iostream>
#include <vector>
#include <random>

#include "IntArray.cpp"

int main(int argc, char* argv[])
{
    IntArray arrayA(5);
    IntArray arrayB(10);
    IntArray arrayC(10);

    std::cout << "1st array = " << arrayA.getElems() << std::endl;
    std::cout << "2nd array = " << arrayB.getElems() << std::endl;
    std::cout << "3d array = " << arrayC.getElems() << std::endl;

    std::cout << "Sorting..." << std::endl;

    arrayA.bubleSort();
    arrayB.quickSort();
    arrayC.stupidSort();

    std::cout << "1st array = " << arrayA.getElems() << std::endl;
    std::cout << "2nd array = " << arrayB.getElems() << std::endl;
    std::cout << "3d array = " << arrayC.getElems() << std::endl;

    return 0;
}

