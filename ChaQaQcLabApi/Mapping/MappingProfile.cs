﻿namespace ChaQaQcLabApi.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Queries mapped
        CreateMap<TimeQueryViewModel, TimeQuery>()
            .ForPath(dest => dest.TimeRange.StartTime, opt => opt.MapFrom(src => src.StartTime))
            .ForPath(dest => dest.TimeRange.StopTime, opt => opt.MapFrom(src => src.StopTime));
        CreateMap<QueryViewModel, Query>();

        // Tester mapped
        CreateMap<Tester, TesterViewModel>();
        CreateMap<TesterViewModel, Tester>();

        // Test mapped
        CreateMap<Test, TestViewModel>();
        CreateMap<TestViewModel, Test>();

        // Product mapped
        CreateMap<Product, ProductViewModel>();
        CreateMap<ProductViewModel, Product>();

        // CurlingForceTest mapped
        CreateMap<CurlingForceTest, CurlingForceTestViewModel>();
        CreateMap<QueryResult<CurlingForceTest>, QueryResult<CurlingForceTestViewModel>>();
        CreateMap<CurlingForceTestViewModel, CurlingForceTest>();
        CreateMap<SaveCurlingForceTestViewModel, CurlingForceTest>();

        // CurlingForceTestSample mapped
        CreateMap<CurlingForceTestSample, CurlingForceTestSampleViewModel>();
        CreateMap<CurlingForceTestSampleViewModel, CurlingForceTestSample>();

        // ForcedCloseTest mapped
        CreateMap<ForcedCloseTest, ForcedCloseTestViewModel>();
        CreateMap<QueryResult<ForcedCloseTest>, QueryResult<ForcedCloseTestViewModel>>();
        CreateMap<ForcedCloseTestViewModel, ForcedCloseTest>();
        CreateMap<SaveForcedCloseTestViewModel, ForcedCloseTest>();

        // ForcedCloseTestSample mapped
        CreateMap<ForcedCloseTestSample, ForcedCloseTestSampleViewModel>();
        CreateMap<ForcedCloseTestSampleViewModel, ForcedCloseTestSample>();

        // ForcedCloseTestSampleResult mapped
        CreateMap<ForcedCloseTestSampleResult, ForcedCloseTestSampleResultViewModel>();
        CreateMap<ForcedCloseTestSampleResultViewModel, ForcedCloseTestSampleResult>();

        // RockTest mapped
        CreateMap<RockTest, RockTestViewModel>();
        CreateMap<QueryResult<RockTest>, QueryResult<RockTestViewModel>>();
        CreateMap<RockTestViewModel, RockTest>();
        CreateMap<SaveRockTestViewModel, RockTest>();

        // RockTestSample mapped
        CreateMap<RockTestSample, RockTestSampleViewModel>();
        CreateMap<RockTestSampleViewModel, RockTestSample>();

        // SoftCloseTest mapped
        CreateMap<SoftCloseTest, SoftCloseTestViewModel>();
        CreateMap<QueryResult<SoftCloseTest>, QueryResult<SoftCloseTestViewModel>>();
        CreateMap<SoftCloseTestViewModel, SoftCloseTest>();
        CreateMap<SaveSoftCloseTestViewModel, SoftCloseTest>();

        // SoftCloseTestSample mapped
        CreateMap<SoftCloseTestSample, SoftCloseTestSampleViewModel>();
        CreateMap<SoftCloseTestSampleViewModel, SoftCloseTestSample>();

        // SoftCloseTestSampleResult mapped
        CreateMap<SoftCloseTestSampleResult, SoftCloseTestSampleResultViewModel>();
        CreateMap<SoftCloseTestSampleResultViewModel, SoftCloseTestSampleResult>();

        // StaticLoadTest mapped
        CreateMap<StaticLoadTest, StaticLoadTestViewModel>();
        CreateMap<QueryResult<StaticLoadTest>, QueryResult<StaticLoadTestViewModel>>();
        CreateMap<StaticLoadTestViewModel, StaticLoadTest>();
        CreateMap<SaveStaticLoadViewModel, StaticLoadTest>();

        // StaticLoadTestSample mapped
        CreateMap<StaticLoadTestSample, StaticLoadTestSampleViewModel>();
        CreateMap<StaticLoadTestSampleViewModel, StaticLoadTestSample>();
    }
}
