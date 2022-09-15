#include <iostream>
#include <random>
#include <vector>

class IntArray
{
public:

    IntArray()
    {
    }

    IntArray(int size) : m_size { size }
    {
        setElems();
    }

    std::string getElems()
    {
        std::string res;

        for (int i = 0; i < m_size; ++i)
            std::cout << m_array.at(i) << ' ';

        return res;
    }

    bool isSorted()
    {
        for (int i = 1; i <= m_size; ++i)
            if ( (m_array[i - 1] > m_array[i]) || (m_array[i - 1] < m_array[i]) )
                return false;
        
        return true;
    }

    void bubleSort()
    {
        for (int i = 0; i < m_size - 1; ++i)
        {
            for (int j = 0; j < m_size - i - 1; ++j)
            {
                if (m_array[j] > m_array[j + 1])
                    std::swap(m_array[j], m_array[j + 1]);
            }
        }
    }

    void quickSort()
    {
        qSort(m_array, 0, m_array.size() - 1);
    }

    void stupidSort()
    {
        for (int i = 1; i < m_size; ++i)
        {
            if (m_array[i - 1] > m_array[i])
            {
                std::swap(m_array[i - 1], m_array[i]);
                i = 0;
            }
        }
    }

private:

    int divide(std::vector<int>& arr, int start, int end)
    {
        int pivot = end;
        int j = start;

        for (int i = start; i < end; ++i)
        {
            if (arr[i] < arr[pivot])
            {
                std::swap(arr[i], arr[j]);
                ++j;
            }
        }

        std::swap(arr[j], arr[pivot]);
        return j;
    }

    void qSort(std::vector<int>& arr, int start, int end)
    {
        if (start < end)
        {
            int half = divide(arr, start, end);
            qSort(arr, start, half - 1);
            qSort(arr, half + 1, end);
        }
    }

    void setElems()
    {
        for (int i = 0; i < m_size; ++i)
            m_array.push_back(std::rand() % 100);
    }

private:
    std::vector<int> m_array;
    int m_size;
};
