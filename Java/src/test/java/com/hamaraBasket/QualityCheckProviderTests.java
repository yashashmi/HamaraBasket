package com.hamaraBasket;

import static org.hamcrest.CoreMatchers.instanceOf;
import static org.junit.Assert.assertThat;

import org.junit.Test;
public class QualityCheckProviderTests
    {
       @Test
        public void shouldGetTheGeneralQualityChecker()
        {
            QualityChecker updater = QualityCheckProvider.GetChecker(ItemType.Expiring);
            assertThat(updater, instanceOf(QualityChecker.class));
        }

        @Test
        public void shouldGetTheLegendaryQualityChecker()
        {
            QualityChecker updater = QualityCheckProvider.GetChecker(ItemType.Legendary);
            assertThat(updater, instanceOf(LegengaryItemQualityChecker.class));
        }

        @Test
        public void shouldGetTheNonExpiryQualityChecker()
        {
            QualityChecker updater = QualityCheckProvider.GetChecker(ItemType.NonExpiry);
            assertThat(updater, instanceOf(NonExpiryItemQualityChecker.class));
        }
    }