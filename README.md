This repo demonstrates the problem that Verify's `UseStrictJson()` does not produce a `.json` snapshot when used directly in the the test.

I have to use `UseStrictJson()` in the module initializer (see commented out code) to make it work.
