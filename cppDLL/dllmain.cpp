#include "pch.h"

extern "C" __declspec(dllexport) long long random(long long seed = 0) {
	static long current = seed;
	current = (current * 1103515245 + 12345) % (1 << 31);
	return current;
}

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

