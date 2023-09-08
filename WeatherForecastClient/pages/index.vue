<script setup lang="ts">
import ForecastDay from "~/types/ForecastDay";

const { data: forecastDays, pending } = useFetch<ForecastDay[]>(`http://localhost:5105/api/forecast`);
</script>

<template>
    <div class="h-screen max-5xl bg-gray-800 px-10 flex items-center">
      <WeatherForecast
        v-if="!pending"
        class="relative z-10 mix-blend-plus-lighter w-full"
        :forecast-days="forecastDays!"
      />
      <div class="mix-blend-soft-light">
        <img src="~/assets/images/WeatherBackground.jpg" class="fixed inset-0 z-0 blur-lg" />
      </div>
    </div>
</template>