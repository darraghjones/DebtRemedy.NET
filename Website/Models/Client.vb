Public Class Client

    Public Property web_number As String = Nothing

    Public Property county_court_claim As Boolean? = Nothing
    Public Property baliff_letter As Boolean? = Nothing
    Public Property struggling_to_pay_bills As Boolean? = Nothing
    Public Property contact_from_collection_agency As Boolean? = Nothing
    Public Property late_fees_on_overdraft As Boolean? = Nothing
    Public Property living_on_credit As Boolean? = Nothing
    Public Property self_employed As Boolean? = Nothing
    Public Property uk_citizen As Boolean? = Nothing
    Public Property live_in_uk As Boolean? = Nothing

    Public Property debt_remedy_for As DebtRemedyFor? = Nothing
    Public Property num_adults_in_home As Integer? = Nothing
    Public Property partner_aware As PartnerAware? = Nothing
    Public Property chilren_under_18 As Integer? = Nothing
    Public Property where_in_uk As Country? = Nothing
    Public Property marital_status As MariageStatus? = Nothing
    Public Property age_bracket As AgeBracket? = Nothing
    Public Property gender As Gender? = Nothing
    Public Property housing_status As HousingStatus? = Nothing
    Public Property tenacy_agreement As TenacyAgreement? = Nothing
    Public Property num_vechicals As Integer? = Nothing
    Public Property num_items_on_hp As Integer? = Nothing
    Public Property any_pets As Boolean? = Nothing
    Public Property little_interest_in_doing_things As DepressionFrquency? = Nothing
    Public Property feeling_down As DepressionFrquency? = Nothing
    Public Property feeling_nervous As DepressionFrquency? = Nothing
    Public Property cant_stop_worrying As DepressionFrquency? = Nothing

    Public Property take_home_pay As Decimal? = Nothing
    Public Property take_home_pay_frequency As PayFrequency? = Nothing
    Public Property rent_received As Decimal? = Nothing
    Public Property pension_received As Decimal? = Nothing
    Public Property income_support As Decimal? = Nothing
    Public Property jobseekers_allowance As Decimal? = Nothing
    Public Property incapacity_benefit As Decimal? = Nothing
    Public Property disability_allowance As Decimal? = Nothing
    Public Property working_tax_credit As Decimal? = Nothing
    Public Property any_other_income As Decimal? = Nothing

End Class

Public Enum DebtRemedyFor
    JustMe
    MyPartnerAndI
End Enum

Public Enum PartnerAware
    Yes
    No
End Enum

Public Enum Country
    EnglandWales
    Scotland
    NorthernIreland
End Enum

Public Enum MariageStatus
    NotMarried
    Married
    Widowed

End Enum
Public Enum AgeBracket
    Under25
    From25to39
    From40to59
    Over60
End Enum

Public Enum Gender
    Male
    Female
End Enum

Public Enum HousingStatus
    Mortgage
    Rent
    Board
    Own
    RentAndMortgage
End Enum

Public Enum TenacyAgreement
    LocalAthority
    HousingAssociation
    PrivateLandlord
End Enum

Public Enum DepressionFrquency
    NotAtAll
    SeveralDays
    MoreThanHalf
    NearyEveryDay
End Enum

Public Enum PayFrequency
    Weekly
    Fortnightly
    FourWeekly
    Monthly
    Quarterly
    Annually
End Enum