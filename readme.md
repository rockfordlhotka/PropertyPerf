# CSLA Property Load Perf

This solution is a test to measure the performance of loading CSLA managed properties - specifically the time needed to do the static loading and creation of the PropertyInfo objects for each managed property.

## Summary

The client project has a `Models` folder which contains a CSLA business type with over 1800 properties.

The `Counter` page is set to run in WebAssembly only, and uses the data portal to fetch an empty instance of the `TestItem` type, thus initializing all the static `PropertyInfo` objects representing those properties.

## Loading the Solution

This solution _directly_ references some CSLA projects. The assumption is the following folder structure:

```
/src/PropertyPerf
/src/rdl/csla/Source
```

If you replicate this folder structure - so the CSLA `main` branch is in `/src/rdl/csla` then the existing project references in the `PropertyPerf` and `PropertyPerf.Client` projects will resolve.

If you have the CSLA `main` branch in another location, you will need to alter the relative paths so the references resolve.

⚠️ CSLA in `main` is currently v9, and so can only be built using Visual Studio 2022 Preview (with .NET 9).
