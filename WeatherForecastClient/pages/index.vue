<script setup lang="ts">
import ForecastDay from "~/types/ForecastDay";

const { data: forecastDays, pending } = useFetch<ForecastDay[]>(`http://localhost:5105/api/forecast`);
</script>

<template>
    <div class="min-h-screen bg-gray-800 px-10 py-10">
      <WeatherForecast
        v-if="!pending"
        class="relative z-10 mix-blend-overlay"
        :forecast-days="forecastDays!"
      />
      <div class="mix-blend-soft-light">
        <img src="~/assets/images/WeatherBackground.jpg" class="fixed inset-0 z-0 blur-lg" />
      </div>
    </div>
</template>