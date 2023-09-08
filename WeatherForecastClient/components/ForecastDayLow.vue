<script setup lang="ts">
defineProps<{ fahrenheit: number, celsius: number, displayFahrenheit: boolean }>();
</script>

<template>
    <div>
        <p class="text-gray-700 font-semibold">
            <span v-if="displayFahrenheit">{{ fahrenheit }}°F</span>
            <span v-else>{{ celsius }}°C</span>
        </p>
    </div>
</template>