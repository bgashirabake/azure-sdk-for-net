// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionModernUsageDetail
    {
        internal static ConsumptionModernUsageDetail DeserializeConsumptionModernUsageDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UsageDetailsKind kind = default;
            Optional<ETag> etag = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> billingAccountId = default;
            Optional<decimal> effectivePrice = default;
            Optional<ConsumptionPricingModelType> pricingModel = default;
            Optional<string> billingAccountName = default;
            Optional<DateTimeOffset> billingPeriodStartDate = default;
            Optional<DateTimeOffset> billingPeriodEndDate = default;
            Optional<string> billingProfileId = default;
            Optional<string> billingProfileName = default;
            Optional<string> subscriptionGuid = default;
            Optional<string> subscriptionName = default;
            Optional<DateTimeOffset> date = default;
            Optional<string> product = default;
            Optional<Guid> meterId = default;
            Optional<string> meterName = default;
            Optional<string> meterRegion = default;
            Optional<string> meterCategory = default;
            Optional<string> meterSubCategory = default;
            Optional<string> serviceFamily = default;
            Optional<decimal> quantity = default;
            Optional<string> unitOfMeasure = default;
            Optional<string> instanceName = default;
            Optional<decimal> costInUSD = default;
            Optional<decimal> unitPrice = default;
            Optional<string> billingCurrencyCode = default;
            Optional<string> resourceLocation = default;
            Optional<string> consumedService = default;
            Optional<string> serviceInfo1 = default;
            Optional<string> serviceInfo2 = default;
            Optional<string> additionalInfo = default;
            Optional<string> invoiceSectionId = default;
            Optional<string> invoiceSectionName = default;
            Optional<string> costCenter = default;
            Optional<string> resourceGroup = default;
            Optional<string> reservationId = default;
            Optional<string> reservationName = default;
            Optional<string> productOrderId = default;
            Optional<string> productOrderName = default;
            Optional<bool> isAzureCreditEligible = default;
            Optional<string> term = default;
            Optional<string> publisherName = default;
            Optional<string> publisherType = default;
            Optional<string> chargeType = default;
            Optional<string> frequency = default;
            Optional<decimal> costInBillingCurrency = default;
            Optional<decimal> costInPricingCurrency = default;
            Optional<string> exchangeRate = default;
            Optional<DateTimeOffset> exchangeRateDate = default;
            Optional<string> invoiceId = default;
            Optional<string> previousInvoiceId = default;
            Optional<string> pricingCurrencyCode = default;
            Optional<string> productIdentifier = default;
            Optional<string> resourceLocationNormalized = default;
            Optional<DateTimeOffset> servicePeriodStartDate = default;
            Optional<DateTimeOffset> servicePeriodEndDate = default;
            Optional<string> customerTenantId = default;
            Optional<string> customerName = default;
            Optional<string> partnerTenantId = default;
            Optional<string> partnerName = default;
            Optional<string> resellerMpnId = default;
            Optional<string> resellerName = default;
            Optional<string> publisherId = default;
            Optional<decimal> marketPrice = default;
            Optional<decimal> exchangeRatePricingToBilling = default;
            Optional<decimal> paygCostInBillingCurrency = default;
            Optional<decimal> paygCostInUSD = default;
            Optional<decimal> partnerEarnedCreditRate = default;
            Optional<string> partnerEarnedCreditApplied = default;
            Optional<decimal> payGPrice = default;
            Optional<string> benefitId = default;
            Optional<string> benefitName = default;
            Optional<string> provider = default;
            Optional<string> costAllocationRuleName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new UsageDetailsKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("billingAccountId"u8))
                        {
                            billingAccountId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("effectivePrice"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            effectivePrice = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("pricingModel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pricingModel = new ConsumptionPricingModelType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingAccountName"u8))
                        {
                            billingAccountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingPeriodStartDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingPeriodStartDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("billingPeriodEndDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingPeriodEndDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("billingProfileId"u8))
                        {
                            billingProfileId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingProfileName"u8))
                        {
                            billingProfileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionGuid"u8))
                        {
                            subscriptionGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionName"u8))
                        {
                            subscriptionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("date"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            date = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("meterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            meterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("meterName"u8))
                        {
                            meterName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("meterRegion"u8))
                        {
                            meterRegion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("meterCategory"u8))
                        {
                            meterCategory = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("meterSubCategory"u8))
                        {
                            meterSubCategory = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceFamily"u8))
                        {
                            serviceFamily = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("quantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("unitOfMeasure"u8))
                        {
                            unitOfMeasure = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instanceName"u8))
                        {
                            instanceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("costInUSD"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            costInUSD = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("unitPrice"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unitPrice = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("billingCurrencyCode"u8))
                        {
                            billingCurrencyCode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceLocation"u8))
                        {
                            resourceLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("consumedService"u8))
                        {
                            consumedService = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceInfo1"u8))
                        {
                            serviceInfo1 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceInfo2"u8))
                        {
                            serviceInfo2 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("additionalInfo"u8))
                        {
                            additionalInfo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("invoiceSectionId"u8))
                        {
                            invoiceSectionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("invoiceSectionName"u8))
                        {
                            invoiceSectionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("costCenter"u8))
                        {
                            costCenter = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"u8))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationId"u8))
                        {
                            reservationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reservationName"u8))
                        {
                            reservationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productOrderId"u8))
                        {
                            productOrderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productOrderName"u8))
                        {
                            productOrderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isAzureCreditEligible"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isAzureCreditEligible = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("term"u8))
                        {
                            term = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherName"u8))
                        {
                            publisherName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherType"u8))
                        {
                            publisherType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("chargeType"u8))
                        {
                            chargeType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("frequency"u8))
                        {
                            frequency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("costInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            costInBillingCurrency = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("costInPricingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            costInPricingCurrency = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("exchangeRate"u8))
                        {
                            exchangeRate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("exchangeRateDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exchangeRateDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("invoiceId"u8))
                        {
                            invoiceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("previousInvoiceId"u8))
                        {
                            previousInvoiceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pricingCurrencyCode"u8))
                        {
                            pricingCurrencyCode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productIdentifier"u8))
                        {
                            productIdentifier = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceLocationNormalized"u8))
                        {
                            resourceLocationNormalized = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("servicePeriodStartDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePeriodStartDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("servicePeriodEndDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePeriodEndDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("customerTenantId"u8))
                        {
                            customerTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customerName"u8))
                        {
                            customerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerTenantId"u8))
                        {
                            partnerTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerName"u8))
                        {
                            partnerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resellerMpnId"u8))
                        {
                            resellerMpnId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resellerName"u8))
                        {
                            resellerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherId"u8))
                        {
                            publisherId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("marketPrice"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            marketPrice = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("exchangeRatePricingToBilling"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exchangeRatePricingToBilling = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("paygCostInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            paygCostInBillingCurrency = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("paygCostInUSD"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            paygCostInUSD = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("partnerEarnedCreditRate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerEarnedCreditRate = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("partnerEarnedCreditApplied"u8))
                        {
                            partnerEarnedCreditApplied = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("payGPrice"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            payGPrice = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("benefitId"u8))
                        {
                            benefitId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("benefitName"u8))
                        {
                            benefitName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provider"u8))
                        {
                            provider = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("costAllocationRuleName"u8))
                        {
                            costAllocationRuleName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConsumptionModernUsageDetail(id, name, type, systemData.Value, kind, Optional.ToNullable(etag), Optional.ToDictionary(tags), billingAccountId.Value, Optional.ToNullable(effectivePrice), Optional.ToNullable(pricingModel), billingAccountName.Value, Optional.ToNullable(billingPeriodStartDate), Optional.ToNullable(billingPeriodEndDate), billingProfileId.Value, billingProfileName.Value, subscriptionGuid.Value, subscriptionName.Value, Optional.ToNullable(date), product.Value, Optional.ToNullable(meterId), meterName.Value, meterRegion.Value, meterCategory.Value, meterSubCategory.Value, serviceFamily.Value, Optional.ToNullable(quantity), unitOfMeasure.Value, instanceName.Value, Optional.ToNullable(costInUSD), Optional.ToNullable(unitPrice), billingCurrencyCode.Value, resourceLocation.Value, consumedService.Value, serviceInfo1.Value, serviceInfo2.Value, additionalInfo.Value, invoiceSectionId.Value, invoiceSectionName.Value, costCenter.Value, resourceGroup.Value, reservationId.Value, reservationName.Value, productOrderId.Value, productOrderName.Value, Optional.ToNullable(isAzureCreditEligible), term.Value, publisherName.Value, publisherType.Value, chargeType.Value, frequency.Value, Optional.ToNullable(costInBillingCurrency), Optional.ToNullable(costInPricingCurrency), exchangeRate.Value, Optional.ToNullable(exchangeRateDate), invoiceId.Value, previousInvoiceId.Value, pricingCurrencyCode.Value, productIdentifier.Value, resourceLocationNormalized.Value, Optional.ToNullable(servicePeriodStartDate), Optional.ToNullable(servicePeriodEndDate), customerTenantId.Value, customerName.Value, partnerTenantId.Value, partnerName.Value, resellerMpnId.Value, resellerName.Value, publisherId.Value, Optional.ToNullable(marketPrice), Optional.ToNullable(exchangeRatePricingToBilling), Optional.ToNullable(paygCostInBillingCurrency), Optional.ToNullable(paygCostInUSD), Optional.ToNullable(partnerEarnedCreditRate), partnerEarnedCreditApplied.Value, Optional.ToNullable(payGPrice), benefitId.Value, benefitName.Value, provider.Value, costAllocationRuleName.Value);
        }
    }
}
